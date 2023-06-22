using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    //связь семьи и члена семьи. человек может быть членом нескольких семей (сын в семье а, отец в семье б)
    [Table("family_member"),Keyless]
    public class FamilyMemberEntity
    {
        [ForeignKey(nameof(MemberId))]
        public MemberEntity Member { get; set; }
        [Column("member_id")]
        public long MemberId { get; set; }
        [ForeignKey(nameof(FamilyId))]
        public FamilyEntity Family { get; set; }
        [Column("family_id")]
        public long FamilyId { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        [ForeignKey(nameof(FamilyRoleId))]
        public FamilyRoleEntity FamilyRole { get; set; }
        [Column("family_role_id")]
        public int FamilyRoleId { get; set; }
        [Column("description"),MaxLength(250)]
        public string? Description { get; set; }
    }
}
