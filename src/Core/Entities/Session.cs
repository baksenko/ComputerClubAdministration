using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Session : BaseEntity
{
    [Required]
    public decimal Price { get; set; }
    [Required]
    public DateTime StartTime { get; set; }
    [Required]
    public DateTime EndTime { get; set; }
    [Required]
    public string Status { get; set; }
    public Administrator Administrator { get; set; }
    public User User { get; set; }
    public WorkStation WorkStation { get; set; }
}