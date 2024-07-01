using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    [Required]
    public required string UserName { get; set; }
    [Required]
    public required byte[] PasswordHash { get; set; }
    [Required]
    public required byte[] PasswordSalt { get; set; }
}
