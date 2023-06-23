using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    [Table("own")]
    public class OwnEntity
    {
        [Key,Column("own_id")]
        public long Id { get; set; }
        [Column("name"),MaxLength(150)]
        public string Name { get; set; }

        

    }
}
