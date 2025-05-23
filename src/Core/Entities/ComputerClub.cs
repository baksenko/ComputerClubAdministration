namespace Core.Entities;

public class ComputerClub
{
    public Guid Id { get; set; }
    public string Address { get; set; }
    public DateTime StartWorkHour { get; set; }
    public DateTime EndWorkHour { get; set; }
    public int GameStations { get; set; }
    public string Name { get; set; }
}