using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class ComputerClub : BaseEntity
{
    [Required]
    public string Address { get; set; }
    [Required]
    public DateTime StartWorkHour { get; set; }
    [Required]
    public DateTime EndWorkHour { get; set; }
    [Required]
    public int GameStations { get; set; }
    [Required]
    public string Name { get; set; }
    public List<Administrator> Administrators { get; set; }
    public List<WorkStation> WorkStations { get; set; }
}