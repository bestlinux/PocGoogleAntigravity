using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BookRegistry.Shared
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da editora é obrigatório.")]
        public string Name { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Website { get; set; } = string.Empty;

        // Relacionamento de navegação
        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }
    }
}
