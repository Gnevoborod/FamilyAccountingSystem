using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    //связь семьи и члена семьи. человек может быть членом нескольких семей (сын в семье а, отец в семье б)
    public class FamilyMember
    {
        public Member Member { get; set; }
        public long MemberId { get; set; }
        public Family Family { get; set; }
        public long FamilyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public FamilyRole FamilyRole { get; set; }
        public int FamilyRoleId { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
    }
}
