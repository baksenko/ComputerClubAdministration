namespace Core.Entities;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string telephone { get; set; }
    public string? Email { get; set; }
    public List<Session> Sessions { get; set; }
}