using System;
using System.ComponentModel.DataAnnotations;

namespace BookRegistry.Shared
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public string ISBN { get; set; } = string.Empty;
    }
}
