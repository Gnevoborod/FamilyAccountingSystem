namespace FamilyAccountingSystem.Domain.Models
{
    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string Description { get; set; }

        public Property Property { get; set; }
        public long PropertyId { get; set; }

    }
}
