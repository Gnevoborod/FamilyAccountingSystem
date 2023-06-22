using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    public class Attribute
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Value { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }

        public Property Property { get; set; }
        public long PropertyId { get; set; }

    }
}
