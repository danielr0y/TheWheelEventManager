namespace EventManager.DomainLayer;

public class EventService : IWebAppEventService
{
    public IEnumerable<Event> UpcomingEvents => new Event[]
    {
        new Event(),
        new Event(),
        new Event()
    };
    public IEnumerable<Event> CancelledEvents => new Event[]
    {
        new Event(),
        new Event(),
        new Event()
    };
}