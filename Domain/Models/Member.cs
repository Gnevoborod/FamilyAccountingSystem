namespace FamilyAccountingSystem.Domain.Models
{
    public class Member
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Surname { get; set; } = default!;
        public string? Patronymic { get; set; } = default!;

        public string? Description { get; set; } = default!;

        public DateOnly? BirthDay { get; set; } = default!;

        public bool? Gender { get; set; } = default!;

        public string? Phone { get; set; } = default!;
        public string? Email { get; set; } = default!;
    }
}
