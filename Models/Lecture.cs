using EduNova.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Lecture
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public DateTime Date {  get; set; }

        public string? FileUrl { get; set; }

        [Required]
        public AcademicYear AcademicYear { get; set; }

        [Required]
        public Semester Semester { get; set; }

        [Required]
        public int SubjectId { get; set; }

        public Subject Subject { get; set; } = null!;

        public ICollection<SavedLecture> SavedLectures { get; set; } = new List<SavedLecture>();

        public ICollection<DownloadedLecture> DownloadedLectures { get; set; } = new List<DownloadedLecture>();
    }
}
