namespace EventManager.DomainLayer;

public class Admin : IUser
{
    public Admin(int id)
    {
        Id = id;
    }

    public int Id { get; }
    public UserType Type => UserType.Admin;
}