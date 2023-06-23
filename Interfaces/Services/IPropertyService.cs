using FamilyAccountingSystem.Domain.Models;

namespace FamilyAccountingSystem.Interfaces.Services
{
    public interface IPropertyService
    {
        public Task CreatePropertyAsync(Property property);
        public Task EditPropertyAsync(Property property);
        public Task<List<Property>> GetPropertiesAsync(long familyId);
        public Task<Property> GetPropertyAsync(long propertyId);
    }
}
