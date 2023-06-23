using FamilyAccountingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    [Table("property_attribute_family"), Keyless]
    public class PropertyAttributeFamilyEntity
    {
        [ForeignKey(nameof(FamilyId))]
        public FamilyEntity Family { get; set; }
        [Column("family_id")]
        public long FamilyId { get; set; }
        [ForeignKey(nameof(AttributeId))]
        public AttributeEntity Attribute { get; set; }
        [Column("attribute_id")]
        public long AttributeId { get; set; }

        [ForeignKey(nameof(PropertyId))]
        public PropertyEntity Property { get; set; }
        [Column("property_id")]
        public long PropertyId { get; set; }
    }
}
