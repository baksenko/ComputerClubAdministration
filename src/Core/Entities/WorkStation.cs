namespace Core.Entities;

public class WorkStation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Type { get; set; }
    public int Place { get; set; }
    public string category {get; set;}  
    public ComputerClub ComputerClub { get; set; }
    public List<Equipment> Equipments { get; set; }
    public List<Session> Sessions { get; set; }
}