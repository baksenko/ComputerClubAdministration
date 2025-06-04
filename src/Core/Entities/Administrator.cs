using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Administrator : BaseEntity
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Telephone { get; set; }
    [Required]
    public string Login { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string DateOfHiring { get; set; }
    public List<Session> Sessions { get; set; }
    public ComputerClub ComputerClub { get; set; }
}