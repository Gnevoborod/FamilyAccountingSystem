using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAccountingSystem.Database.Entities
{
    [Table("member")]
    public class MemberEntity
    {
        [Key, Column("member_id")]
        public long Id { get; set; }
        [Column("name"),MaxLength(100)]
        public string Name { get; set; } = default!;
        [Column("surname"), MaxLength(100)]
        public string? Surname { get; set; } = default!;
        [Column("patronymic"), MaxLength(100)]
        public string? Patronymic { get; set; } = default!;
        [Column("description"), MaxLength(200)]
        public string? Description { get; set; } = default!;
        [Column("birthday")]
        public DateOnly? BirthDay { get; set; } = default!;
        [Column("gender")]
        public bool? Gender { get; set; } = default!;
        [Column("phone"),MaxLength(20)]
        public string? Phone { get; set; } = default!;
        [Column("email"),MaxLength(100)]
        public string? Email { get; set; } = default!;
    }
}
