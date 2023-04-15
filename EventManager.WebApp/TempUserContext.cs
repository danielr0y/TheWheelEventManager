using EventManager.DomainLayer;
using EventManager.WebApp;

namespace WebApp;

public class TempUserContext : IWebAppUserContext
{
    public TempUserContext()
    {
        User = new WebAppUser(2, UserType.Customer);
    }
    public IUser User { get; }
}