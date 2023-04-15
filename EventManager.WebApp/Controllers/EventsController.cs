using EventManager.DomainLayer;
using EventManager.WebApp;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class EventsController : Controller
{
    private readonly IWebAppEventService _eventService;
    private readonly IWebAppTicketService _ticketService;
    private readonly IWebAppBookingService _bookingService;
    private readonly IWebAppCustomerService _customerService;
    private readonly IWebAppUserContext _userContext;

    public EventsController(IWebAppEventService eventService, IWebAppTicketService ticketService, IWebAppBookingService bookingService, IWebAppCustomerService customerService, IWebAppUserContext userContext)
    {
        _eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
        _ticketService = ticketService ?? throw new ArgumentNullException(nameof(ticketService));
        _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
        _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        _userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
    }

    public IActionResult Index()
    {
        return View(
            new AllEventsViewModel(
                "All Events",
                new EventsPartialViewModel(
                    "All Events",
                    _eventService.AllEvents.Select( Event =>
                        new EventPreviewPartialViewModel(Event) ))));
    }

    public RedirectToActionResult Book()
    {
        string message = "";

        try
        {
            int ticketId = 3;
            int qty = 4;
            string discountCode = "FULLPRICELOL";

            Customer customer = _customerService.GetCustomer(_userContext.User.Id);
            Ticket ticket = _ticketService.GetTicket(ticketId);
            decimal multiplier = 1; // getMultiplier(discountCode);
            decimal purchasePrice = ticket.Price * qty * multiplier;

            customer.Purchase(_bookingService, ticket, qty, purchasePrice, DateTime.Now);

            message = "Thank you for your purchase";
        }
        catch (UserIsNotACustomer e)
        {
            message = $"User is {e.User.Type.ToString()}. Must be Customer";
        }
        catch (PurchaseExceedsCustomerBudget e)
        {
            message = $"This purchase would exceeded your personal budget of {e.Budget}. We did not attempt this purchase.";
        }
        catch (InsufficientGondolasRemaining e)
        {
            message = $"We cannot accommodate for your request. There are only {e.RemainingGondolas} gondolas remaining.";
        }
        catch (BookingFailure e)
        {
            message = $"Something went wrong. {e.Message}";
        }

        return RedirectToAction(
            actionName: "Index",
            controllerName: "Home",
            new[]
            {
                message
            });
    }

    public IActionResult Event(int id)
    {
        var Event = _eventService.GetEvent(id);
        var tickets = _ticketService.GetTickets(Event);

        var ticketsFormattedForTimeRow = _ticketService.FormatDataForTicketTableTimeRow(tickets);
        var ticketsFormattedForDateRows = _ticketService.FormatDataForTicketTableDateRows(tickets);

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