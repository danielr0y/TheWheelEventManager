namespace EventManager.DomainLayer;

public class UserIsNotACustomer : Exception
{
    public UserIsNotACustomer(IUser user)
    {
        User = user;
    }

    public IUser User { get; }
}