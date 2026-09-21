using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; } = string.Empty;

        [StringLength(35)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(11)]
        [Phone]
        public string? Phone { get; set; }

        public string? Bio { get; set; }

        public ICollection<Subject> Subjects { get; set; }
            = new List<Subject>();

        public ICollection<Attendance> Attendances { get; set; }
            = new List<Attendance>();
    }
}