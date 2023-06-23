using FamilyAccountingSystem.Database;
using FamilyAccountingSystem.Database.Entities;
using FamilyAccountingSystem.Domain.Models;
using FamilyAccountingSystem.Infrastructure.Mappers;
using FamilyAccountingSystem.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Property = FamilyAccountingSystem.Domain.Models.Property;


namespace FamilyAccountingSystem.Repositories
{
    public class PropertyRepository:IPropertyRepository
    {
        private readonly FamilyContext _familyContext;
        public PropertyRepository(FamilyContext familyContext)
        {
            _familyContext = familyContext;
        }
        public async Task CreatePropertyAsync(Property property, long familyId)
        {
            throw new NotImplementedException();
        }
        public async Task EditPropertyAsync(Property property)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Property>> GetPropertiesAsync(long familyId)
        {
            var attributesIds = await _familyContext.OwnPropertyFamilyEntities.Where(paf => paf.FamilyId == familyId).Select(paf => paf.PropertyId).ToListAsync();
            var attributes = await _familyContext.PropertyEntity.Join<PropertyEntity, long,long,Property> (
                attributesIds, 
                a => a.Id, 
                b => b,
                (ab, ff)=> ab.FromEntityToModel()).ToListAsync();
            return attributes;
        }
        public async Task<Property> GetPropertyAsync(long propertyId)
        {
            throw new NotImplementedException();
        }
    }
}
