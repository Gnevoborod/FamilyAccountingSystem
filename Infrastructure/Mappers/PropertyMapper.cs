using FamilyAccountingSystem.Controllers.Dtos.Property;
using FamilyAccountingSystem.Database.Entities;
using FamilyAccountingSystem.Domain.Models;

namespace FamilyAccountingSystem.Infrastructure.Mappers
{
    public static class PropertyMapper
    {
        public static Property FromEntityToModel(this PropertyEntity entity)
        {
            if (entity == null)
                return default!;
            return new Property
            {
                Id = entity.Id,
                Name = entity.Name,
                Value = entity.Value,
                Description = entity.Description
            };
        }

        public static PropertyDto FromModelToDto(this Property attribute)
        {
            if(attribute == null)
                return default!;
            return new PropertyDto
            {
                Id = attribute.Id,
                Name = attribute.Name,
                Value = attribute.Value,
                Description = attribute.Description
            };
        }

        public static List<PropertyDto> FromModelListToDtoList(this List<Property> attributes)
        {
            if (attributes == null)
                return default!;
            var result = new List<PropertyDto>(attributes.Count);
            foreach (var attr in attributes)
                result.Add(attr.FromModelToDto());
            return result;
        }
    }
}
