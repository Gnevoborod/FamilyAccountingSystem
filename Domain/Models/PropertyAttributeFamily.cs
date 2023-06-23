namespace FamilyAccountingSystem.Domain.Models
{
    //Можем переиспользовать атрибуты для собственности внутри семьи
    public class PropertyAttributeFamily
    {
        public Family Family { get; set; }
        public long FamilyId { get; set; }

        public Attribute Attribute { get; set; }
        public long AttributeId { get; set; }

        public Property Property { get; set; }

        public long PropertyId { get; set; }
    }
}
