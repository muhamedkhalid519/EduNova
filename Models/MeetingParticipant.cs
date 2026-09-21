using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class MeetingParticipant
    {
        public int Id {  get; set; }

        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; } = null!;

        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public DateTime JoinedAt {  get; set; }

    }
}
