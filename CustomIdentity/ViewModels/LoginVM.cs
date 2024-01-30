using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels;

public class LoginVM
{
    [Required(ErrorMessage = "Username is required.")]
    public string? Username { get; set; }
    
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required.")]
    public string? Password { get; set; }

    [Display(Name = "Remember me.")]
    public bool RememberMe { get; set; }
}