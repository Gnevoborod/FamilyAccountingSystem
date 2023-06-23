namespace FamilyAccountingSystem.Domain.Models
{
    //Можем переиспользовать атрибуты для собственности внутри семьи
    public class OwnPropertyFamily
    {
        public Family Family { get; set; }
        public long FamilyId { get; set; }

        public Property Property { get; set; }
        public long PropertyId { get; set; }

        public Own Own { get; set; }

        public long OwnId { get; set; }
    }
}
