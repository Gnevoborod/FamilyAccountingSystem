using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    //Семья
    [Table("family")]
    public class FamilyEntity
    {
        [Key,Column("family_id")]
        public long Id { get; set; }
        [Column("name"),MaxLength(100)]
        public string Name { get; set; }
        [Column("description"),MaxLength(250)]
        public string? Description { get; set; }
    }
}
