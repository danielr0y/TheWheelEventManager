using EventManager.DomainLayer;

namespace EventManager.WebApp;

public interface IWebAppUserContext
{
    IUser User { get; }
}