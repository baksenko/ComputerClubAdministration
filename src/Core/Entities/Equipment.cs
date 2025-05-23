namespace Core.Entities;

public class Equipment
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    public string Model { get; set; }
    public string WorkingCondition { get; set; }
}