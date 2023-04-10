using EventManager.DomainLayer;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class EventsController : Controller
{
    private readonly IWebAppEventService _eventService;

    public EventsController(IWebAppEventService eventService)
    {
        _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
    }

    public IActionResult Index()
    {
        return View(
            new AllEventsViewModel(
                "All Events",
                new EventsPartialViewModel(
                    "All Events",
                    _eventService.AllEvents.Select( Event => new EventPreviewPartialViewModel(Event) ))));
    }

    public IActionResult Event(int id)
    {
        return View(
            new EventViewModel(
                _eventService.GetEvent(id)));
    }
}