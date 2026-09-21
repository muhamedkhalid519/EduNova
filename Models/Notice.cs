using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Notice
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(2000, MinimumLength = 5)]
        public string Content {  get; set; } = string.Empty;

        [Required]
        public DateTime PublishedAt { get; set; }
    }
}
