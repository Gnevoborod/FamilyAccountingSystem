using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    //Семья
    public class Family
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
    }
}
