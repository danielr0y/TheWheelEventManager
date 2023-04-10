namespace EventManager.DomainLayer;

/**
 * most behaviours are just going to forward the request onto the repository
 * but this is not the only job of this Service.
 * other behaviours related to a collection of Events can be offered here.
 * eg, a sorting algorithm that accepts a collection of Events and returns them in another order
 */
public class EventService : IWebAppEventService
{
    private readonly IEventRepository _eventRepository;

    public EventService(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public IEnumerable<Event> UpcomingEvents => _eventRepository.UpcomingEvents;
    public IEnumerable<Event> CancelledEvents => _eventRepository.CancelledEvents;
}