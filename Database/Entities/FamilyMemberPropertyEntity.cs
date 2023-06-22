using FamilyAccountingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    //связь семьи, члена семьи и собственности (отец из семьи а владеет авто, и он же сын и семьи б и владеет квартирой)
    [Table("famiy_member_property"), Keyless]
    public class FamilyMemberPropertyEntity
    {
        [ForeignKey(nameof(FamilyId))]
        public FamilyEntity Family { get; set; }
        [Column("famiy_member_property_id")]
        public long FamilyId { get; set; }
        [ForeignKey(nameof(MemberId))]
        public MemberEntity Member { get; set; }
        [Column("member_id")]
        public long MemberId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public PropertyEntity Property { get; set; }
        [Column("property_id")]
        public long PropertyId { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        [Column("description"),MaxLength(250)]
        public string? Description { get; set; }
    }
}
