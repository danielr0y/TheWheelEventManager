using System.Net.Mime;
using EventManager.DomainLayer;

namespace WebApp.Models;

public class EventPreviewPartialViewModel
{
    public int Id { get; }
    public string Name { get; }
    public string DateRange { get; }
    public string TimeRange { get; }
    public string Excerpt { get; }
    public string EventStatus { get; }
    public string UIColor { get; }
    public string ButtonText { get; }
    public string LowestPrice { get; }
    public string ImageURL { get; }

    public EventPreviewPartialViewModel(Event Event)
    {
        var isUpcoming = (Event.Status == Status.Upcoming);

        Id = Event.Id;
        Name = Event.Name;
        DateRange = "not implemented yet";
        TimeRange = "not implemented yet";
        Excerpt = Event.Excerpt;
        EventStatus = Event.Status.ToString();
        UIColor = UIService.GetColorStringByStatus(Event.Status);
        LowestPrice = "not implemented yet";
        ButtonText = isUpcoming ? "View Event" : Event.Status.ToString();
        ImageURL = $"/images/{Event.ImageURL}";
    }
}