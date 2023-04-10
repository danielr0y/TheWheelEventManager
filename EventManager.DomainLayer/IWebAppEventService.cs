namespace EventManager.DomainLayer;
/**
 * this would typically be owned by the application that is programming to it/defining it
 * it has been moved to the domain layer to retain consistency in the direction of dependencies across the n-tiers
 *
 * question: given that a user interface will always be dependent on its underlying domain layer,
 * why program to an interface here at all?
 * especially when we are having to undermine the dependency inversion principle to realise it anyway.
 * ie.) the interface is distributed with the domain layer...
 * ...so that the UI depends on the domain layer and not other way around.
 *
 * why not just couple the UI directly to the domain layer?
 * perhaps because the domain layer can service multiple user interfaces.
 *
 * when programming to interfaces the web app can state what it requires in the IWebAppEventService
 * and the mobile app can state what it requires in the IMobileAppEventService
 *
 * that way, if the Service has to change to please one UI, the other doesnt have to be rebuilt
 */
public interface IWebAppEventService
{
    IEnumerable<Event> UpcomingEvents { get; }
    IEnumerable<Event> CancelledEvents { get; }
    IEnumerable<Event> AllEvents { get; }
    Event GetEvent(int id);
}