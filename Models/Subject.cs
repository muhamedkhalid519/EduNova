using EduNova.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [StringLength(20)]
        public String? Code { get; set; }

        [Required]
        public AcademicYear AcademicYear { get; set; }

        [Required]
        public Semester Semester { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();

        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    }
}
