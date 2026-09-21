using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class DownloadedLecture
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [Required]
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; } = null!;

        public DateTime DownloadedAt {  get; set; }
    }
}
