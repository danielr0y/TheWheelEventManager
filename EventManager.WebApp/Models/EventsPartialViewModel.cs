namespace WebApp.Models;

public class EventsPartialViewModel
{
    public EventsPartialViewModel(string heading, IEnumerable<EventPreviewPartialViewModel> events)
    {
        Heading = heading;
        Events = events;
        NumberOfEvents = Events.Count();
    }

    public string Heading { get; }
    public IEnumerable<EventPreviewPartialViewModel> Events { get; }
    public int NumberOfEvents { get; }
}