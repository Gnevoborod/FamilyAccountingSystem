using FamilyAccountingSystem.Interfaces.Repositories;
using FamilyAccountingSystem.Interfaces.Services;
using Property = FamilyAccountingSystem.Domain.Models.Property;
namespace FamilyAccountingSystem.Services
{
    public class PropertyService:IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;
        
        public PropertyService(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        public Task CreatePropertyAsync(Property property)
        {
            throw new NotImplementedException();
        }
        public Task EditPropertyAsync(Property property)
        {
            throw new NotImplementedException();
        }
        public Task<List<Property>> GetPropertiesAsync(long familyId)
        {
            return _propertyRepository.GetPropertiesAsync(familyId);
        }
        public Task<Property> GetPropertyAsync(long propertyId)
        {
            throw new NotImplementedException();
        }
    }
}
