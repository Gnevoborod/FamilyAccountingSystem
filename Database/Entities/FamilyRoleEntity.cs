using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities {
    //роль в семье (отец, сын и т.д.)
    [Table("family_role")]
    public class FamilyRoleEntity
    {
        [Key,Column("family_role_id")]
        public int Id { get; set; }
        [Column("name"),MaxLength(50)]
        public string Name { get; set; }
        
    }
}
