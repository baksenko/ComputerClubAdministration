namespace Core.Entities;

public class Administrator
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string DateOfHiring { get; set; }
}