using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    //связь семьи, члена семьи и собственности (отец из семьи а владеет авто, и он же сын и семьи б и владеет квартирой)
    public class FamilyMemberOwn
    {
        public Family Family { get; set; }
        public long FamilyId { get; set; }
        public Member Member { get; set; }
        public long MemberId { get; set; }
        public Own Own { get; set; }
        public long OwnId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
    }
}
