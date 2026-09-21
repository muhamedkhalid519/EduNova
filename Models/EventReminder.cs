using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class EventReminder
    {
        public int Id { get; set; }

        [Required]
        public int UserId {  get; set; }
        public User User { get; set; } = null!;

        [Required]
        public int EventId { get; set; }
        public Event Event { get; set; } = null!;

        [Required]
        public DateTime ReminderAt { get; set; }
    }
}
