using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [StringLength (50, MinimumLength = 5)]
        public string Name {  get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(25)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Phone]
        [StringLength(11)]
        public string Phone {  get; set; } = string.Empty;


        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        public ICollection<Note> Notes { get; set; } = new List<Note>();

        public ICollection<Meeting> CreatedMeetings { get; set; } = new List<Meeting>();

        public ICollection<MeetingParticipant> MeetingParticipants { get; set; } = new List<MeetingParticipant>();

        public ICollection<SavedLecture> SavedLectures { get; set; } = new List<SavedLecture>();

        public ICollection<DownloadedLecture> DownloadedLectures { get; set; } = new List<DownloadedLecture>();

        public ICollection<EventReminder> EventReminders { get; set; } = new List<EventReminder>();
    }
}
