namespace FamilyAccountingSystem.Domain.Models
{
    //связь семьи, члена семьи и собственности (отец из семьи а владеет авто, и он же сын и семьи б и владеет квартирой)
    public class FamilyMemberProperty
    {
        public Family Family { get; set; }
        public Member Member { get; set; }
        public Property Property { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
