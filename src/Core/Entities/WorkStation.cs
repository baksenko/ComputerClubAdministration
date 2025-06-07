using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class WorkStation : BaseEntity
{
    [Required]
    public string Type { get; set; }
    [Required]
    public int Place { get; set; }
    [Required]
    public string Category {get; set;}  
    public ComputerClub ComputerClub { get; set; }
    public List<Equipment> Equipments { get; set; }
    public List<Session> Sessions { get; set; }
}