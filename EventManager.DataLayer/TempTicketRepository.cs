using EventManager.DomainLayer;

namespace EventManager.DataLayer;

public class TempTicketRepository : ITicketRepository
{
    public Ticket GetTicket(int id) =>
        new Ticket(
            id,
            new Event(1, Status.Upcoming),
            new DateTime(2023, 5, 4, 18, 30, 0));

    public IEnumerable<Ticket> GetTickets(Event Event) =>
        new Ticket[]
        {
            new Ticket(1, Event, new DateTime(2023, 5, 4, 18, 30, 0)),
            new Ticket(2, Event, new DateTime(2023, 5, 4, 19, 0, 0)),
            new Ticket(3, Event, new DateTime(2023, 5, 4, 19, 30, 0)),
            new Ticket(4, Event, new DateTime(2023, 5, 5, 18, 30, 0)),
            new Ticket(5, Event, new DateTime(2023, 5, 5, 19, 0, 0)),
            new Ticket(6, Event, new DateTime(2023, 5, 5, 19, 30, 0)),
            new Ticket(7, Event, new DateTime(2023, 5, 6, 18, 30, 0)),
            new Ticket(8, Event, new DateTime(2023, 5, 6, 19, 0, 0)),
            new Ticket(9, Event, new DateTime(2023, 5, 6, 19, 30, 0))
        };
}