﻿using System.ComponentModel.DataAnnotations;

namespace FamilyAccountingSystem.Domain.Models
{
    public class Member
    {
        public long Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(100)]
        public string? Surname { get; set; } = default!;
        [MaxLength(100)]
        public string? Patronymic { get; set; } = default!;
        [MaxLength(200)]
        public string? Description { get; set; } = default!;

        public DateOnly? BirthDay { get; set; } = default!;

        public bool? Gender { get; set; } = default!;
        [MaxLength(20)]
        public string? Phone { get; set; } = default!;
        [MaxLength(100)]
        public string? Email { get; set; } = default!;
    }
}
