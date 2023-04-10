using System.Diagnostics;
using EventManager.DomainLayer;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly IWebAppEventService _eventService;

    public HomeController(IWebAppEventService eventService)
    {
        _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
    }

    public IActionResult Index()
    {
        return View(
            new HomeViewModel(
                "The Wheel of Brisbane",
                new EventsPartialViewModel(
                    "Upcoming Events",
                    _eventService.UpcomingEvents.Select( Event => new EventPreviewPartialViewModel(Event) )
                ),
                new EventsPartialViewModel(
                    "Cancelled Events",
                    _eventService.CancelledEvents.Select( Event => new EventPreviewPartialViewModel(Event) )
                )
            )
        );
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}