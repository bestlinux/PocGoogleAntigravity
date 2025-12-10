using System;
using System.ComponentModel.DataAnnotations;

namespace BookRegistry.Shared
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "O autor é obrigatório.")]
        public string Author { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public string ISBN { get; set; } = string.Empty;

        public string? CoverImageBase64 { get; set; }
    }
}
