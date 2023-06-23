using FamilyAccountingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    [Table("own_property_family"), Keyless]
    public class OwnPropertyFamilyEntity
    {
        [ForeignKey(nameof(FamilyId))]
        public FamilyEntity Family { get; set; }
        [Column("family_id")]
        public long FamilyId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public PropertyEntity Property { get; set; }
        [Column("property_id")]
        public long PropertyId { get; set; }

        [ForeignKey(nameof(OwnId))]
        public OwnEntity Own { get; set; }
        [Column("own_id")]
        public long OwnId { get; set; }
    }
}
