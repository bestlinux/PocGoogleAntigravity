using System.ComponentModel.DataAnnotations;

namespace BookRegistry.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "O e-mail não é válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; } = string.Empty;
    }
}
