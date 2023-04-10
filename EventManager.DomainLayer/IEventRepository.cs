namespace EventManager.DomainLayer;

public interface IEventRepository
{
    IEnumerable<Event> UpcomingEvents { get; }
    IEnumerable<Event> CancelledEvents { get; }
    IEnumerable<Event> AllEvents { get; }
    Event GetEvent(int id);
}