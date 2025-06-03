namespace Core.Entities;

public class Administrator : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string DateOfHiring { get; set; }
    public List<Session> Sessions { get; set; }
    public ComputerClub ComputerClub { get; set; }
}