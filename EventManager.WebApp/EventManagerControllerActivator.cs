using EventManager.DataLayer;
using EventManager.DomainLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using WebApp.Controllers;

namespace WebApp;

/**
 * composition root
 * creates object graphs
 *
 * facilitates injecting dependencies into controllers
 * alternative approaches:
 * DI container
 * no constructor injection
 */
public class EventManagerControllerActivator : IControllerActivator
{
    public object Create(ControllerContext context) =>
        Create( context.ActionDescriptor.ControllerTypeInfo.AsType() );

    private static Controller Create(Type type)
    {
        switch (type.Name)
        {
            case nameof(HomeController):
                return new HomeController(
                    new EventService(
                        new TempEventRepository()));
            default:
                throw new InvalidOperationException($"Unknown controller {type}.");
        }
    }

    public void Release(ControllerContext context, object controller) =>
        (controller as IDisposable)?.Dispose();
}