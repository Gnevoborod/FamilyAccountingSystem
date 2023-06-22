using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FamilyAccountingSystem.Database
{
    public class FamilyContextFactory: IDesignTimeDbContextFactory<FamilyContext>
    {
        public FamilyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamilyContext>();
            return new FamilyContext();
        }
    }
}
