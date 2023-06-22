using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    public class Property
    {
        public long Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
