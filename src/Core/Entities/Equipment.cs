namespace Core.Entities;

public class Equipment : BaseEntity
{
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    public string Model { get; set; }
    public string WorkingCondition { get; set; }
    public WorkStation WorkStation { get; set; }
}