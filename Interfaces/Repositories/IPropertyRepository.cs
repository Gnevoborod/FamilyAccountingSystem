using FamilyAccountingSystem.Domain.Models;

namespace FamilyAccountingSystem.Interfaces.Repositories;

public interface IPropertyRepository
{
    public Task CreatePropertyAsync(Property property, long familyId);
    public Task EditPropertyAsync(Property property);
    public Task<List<Property>> GetPropertiesAsync(long familyId);
    public Task<Property> GetPropertyAsync(long propertyId);
}
