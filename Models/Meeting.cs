using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        public bool VideoEnabled { get; set; }

        [Required]
        public bool AudioEnabled { get; set; }

        [Required]
        [StringLength(20)]
        public string MeetingCode { get; set; } = string.Empty;

        [Required]
        public int CreatedByUserId { get; set;  }

        public User CreatedByUser { get; set; } = null!;

        public ICollection<MeetingParticipant> Participants { get; set; } = new List<MeetingParticipant>();
    }
}
