using EventManager.DomainLayer;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class EventsController : Controller
{
    private readonly IWebAppEventService _eventService;
    private readonly IWebAppTicketService _ticketService;

    public EventsController(IWebAppEventService eventService, IWebAppTicketService ticketService)
    {
        _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
        _ticketService = ticketService ?? throw new ArgumentNullException(nameof(ticketService));
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
        var Event = _eventService.GetEvent(id);
        var ticketsFormattedForTimeRow = _ticketService.FormatDataForTicketTableTimeRow(_ticketService.GetTickets(Event));
        var ticketsFormattedForDateRows = _ticketService.FormatDataForTicketTableDateRows(_ticketService.GetTickets(Event));

        return View(
            new EventViewModel(
                Event,
                new TicketTableViewModel(
                    new TicketTableTimeRowViewModel(
                        ticketsFormattedForTimeRow.Select( timeCell =>
                            new TicketTableTimeCellViewModel(timeCell) )
                    ),
                    ticketsFormattedForDateRows.Select( dateRow =>
                        new TicketTableDateRowViewModel(
                            dateRow.Key,
                            dateRow.Select( ticket => new TicketTableTicketCellViewModel(ticket) )
                        )
                    ))));
    }
}