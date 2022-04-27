using System.ComponentModel.DataAnnotations;

namespace Asp_Document_Reader.Shared;

public class UserInfo
{
    [Required(ErrorMessage = "Informe um email")]
    [EmailAddress(ErrorMessage = "Formato do email inválido")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe a senha")]
    public string Password { get; set; } = string.Empty;

}
