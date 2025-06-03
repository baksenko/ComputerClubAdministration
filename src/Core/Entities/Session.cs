namespace Core.Entities;

public class Session : BaseEntity
{
    public decimal Price { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Status { get; set; }
    public Administrator Administrator { get; set; }
    public User User { get; set; }
    public WorkStation WorkStation { get; set; }
}