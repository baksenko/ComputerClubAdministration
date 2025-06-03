namespace Core.Entities;

public class ComputerClub : BaseEntity
{
    public string Address { get; set; }
    public DateTime StartWorkHour { get; set; }
    public DateTime EndWorkHour { get; set; }
    public int GameStations { get; set; }
    public string Name { get; set; }
    public List<Administrator> Administrators { get; set; }
    public List<WorkStation> WorkStations { get; set; }
}