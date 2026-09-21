using System.ComponentModel.DataAnnotations;

namespace EduNova.Api.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Author { get; set; }
    }
}
