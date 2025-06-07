using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class User : BaseEntity
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Telephone { get; set; }
    [Required]
    public string? Email { get; set; }
    public List<Session> Sessions { get; set; }
}