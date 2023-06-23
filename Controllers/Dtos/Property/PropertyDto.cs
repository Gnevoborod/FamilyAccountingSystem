using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Controllers.Dtos.Property
{
    public class PropertyDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string? Description { get; set; }
    }
}
