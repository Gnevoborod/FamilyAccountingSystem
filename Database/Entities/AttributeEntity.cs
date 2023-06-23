using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    [Table("attribute"), Keyless]
    public class AttributeEntity
    {
        [Column("name"),MaxLength(100)]
        public string Name { get; set; }
        [Column("value"),MaxLength(100)]
        public string Value { get; set; }
        [Column("description"),MaxLength(250)]
        public string? Description { get; set; }

    }
}
