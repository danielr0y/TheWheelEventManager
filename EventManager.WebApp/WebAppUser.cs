using EventManager.DomainLayer;

namespace EventManager.WebApp;

public class WebAppUser : IUser
{
    public WebAppUser(int id, UserType type)
    {
        Id = id;
        Type = type;
    }

    public int Id { get; }
    public UserType Type { get; }
    public bool IsCustomer => (Type == UserType.Customer);
}