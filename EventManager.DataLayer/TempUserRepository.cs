using EventManager.DomainLayer;

namespace EventManager.DataLayer;

public class TempUserRepository : ICustomerRepository
{
    private readonly List<IUser> _users;

    public TempUserRepository()
    {
        _users =
            new List<IUser>
            {
                new Admin(1),
                new Customer(2),
                new Customer(3),
                new Customer(4)
            };
    }

    public Customer GetCustomer(int id)
    {
        var user = _users.Single( user => user.Id == id);
        return (user.Type == UserType.Customer)
            ? (Customer)user
            : throw new UserIsNotACustomer(user);
    }
}