using System.ComponentModel.DataAnnotations;

namespace PasswordManager.Data.Models;

public class PasswordEntry
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "A origem (Site/App) é obrigatória.")]
    public string Origem { get; set; } = string.Empty;

    [Required(ErrorMessage = "O usuário é obrigatório.")]
    public string Usuario { get; set; } = string.Empty;

    [Required(ErrorMessage = "A senha é obrigatória.")]
    public string SenhaCriptografada { get; set; } = string.Empty;
}
