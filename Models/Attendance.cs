using EduNova.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan From { get; set; }

        [Required]
        public TimeSpan To {  get; set; }

        [Required]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = null!;

        [Required]
        public AttendanceStatus Status {  get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; } = null!;
    }
}
