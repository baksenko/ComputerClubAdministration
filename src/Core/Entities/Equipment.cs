using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Equipment : BaseEntity
{
    [Required]
    public string Type { get; set; }
    [Required]
    public string SerialNumber { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public string WorkingCondition { get; set; }
    public WorkStation WorkStation { get; set; }
}