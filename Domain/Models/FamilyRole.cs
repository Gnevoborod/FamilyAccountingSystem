using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    //роль в семье (отец, сын и т.д.)
    public class FamilyRole
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        
    }
}
