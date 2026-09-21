using EduNova.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal Score { get; set; }

        [Required]
        public AcademicYear AcademicYear { get; set; }

        [Required]
        public Semester Semester { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        [Required]
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;
    }

    
}
