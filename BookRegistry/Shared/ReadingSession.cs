using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookRegistry.Shared
{
    public class ReadingSession
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        public DateTime StartTime { get; set; } = DateTime.Now;

        public DateTime EndTime { get; set; } = DateTime.Now;

        public int PagesRead { get; set; }

        public string? Notes { get; set; }

        // Navigation property
        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        [NotMapped]
        public bool IsFinalSession { get; set; }
    }
}
