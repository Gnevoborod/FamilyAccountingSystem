using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;

namespace FamilyAccountingSystem.Database
{
    public class FamilyContextFactory
    {
        public FamilyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FamilyContext>();
            return new FamilyContext();
        }
    }
}
