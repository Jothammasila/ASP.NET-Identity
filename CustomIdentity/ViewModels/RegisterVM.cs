using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels;

public class RegisterVM
{
    [Required]
    public string? Name { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords don't match.")]
    public string? ConfirmPassword { get; set; }
    
    [DataType(DataType.MultilineText)]
    public string? Address { get; set; }
}