using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public DateTime Date {  get; set; }

        public ICollection<EventReminder> Reminders { get; set; } = new List<EventReminder>();
    }
}
