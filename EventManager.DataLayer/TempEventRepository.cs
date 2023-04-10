using EventManager.DomainLayer;

namespace EventManager.DataLayer;

public class TempEventRepository : IEventRepository
{
    private List<Event> _events;

    public TempEventRepository()
    {
        _events =
            new List<Event>
            {
                new Event(1, Status.Upcoming),
                new Event(2, Status.Upcoming),
                new Event(3, Status.Cancelled),
                new Event(4, Status.Upcoming),
                new Event(5, Status.Cancelled),
                new Event(6, Status.Cancelled)
            };
    }

    public IEnumerable<Event> UpcomingEvents => _events.Where( Event => Event.Status == Status.Upcoming ).ToList();
    public IEnumerable<Event> CancelledEvents => _events.Where( Event => Event.Status == Status.Cancelled ).ToList();
    public IEnumerable<Event> AllEvents => _events;
}