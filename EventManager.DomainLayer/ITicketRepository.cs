namespace EventManager.DomainLayer;

public interface ITicketRepository
{
    IEnumerable<Ticket> GetTickets(Event Event);
}