using Microsoft.EntityFrameworkCore;
using NLog.Web;
using System.Diagnostics;

namespace FamilyAccountingSystem.Database
{
    public class FamilyContext: DbContext
    {
        private string connectionString = default!;
        private void SetConnectionString(bool IntegrationTests = false)
        {
            var config = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json").Build();
            connectionString = config.GetConnectionString("DatabaseConnectionString") ?? throw new NullReferenceException("Невозможно получить путь к базе");
        }

        public FamilyContext()
        {
            if (connectionString == null)
                SetConnectionString();
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (String.IsNullOrEmpty(connectionString))
                    throw new ArgumentNullException("connectionString");
                optionsBuilder.UseNpgsql(connectionString)
                    .EnableSensitiveDataLogging()
                    .UseLoggerFactory(
                        LoggerFactory.Create(
                                builder => builder.AddNLogWeb()
                                )
                        );
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=bbqueue;Username=postgres;Password=qwerty");
        }
    }
}
