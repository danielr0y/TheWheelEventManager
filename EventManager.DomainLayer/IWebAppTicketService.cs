namespace EventManager.DomainLayer;

public interface IWebAppTicketService
{
    IEnumerable<TimeOnly> FormatDataForTicketTableTimeRow(IEnumerable<Ticket> tickets);
    IEnumerable<IGrouping<DateOnly, Ticket>> FormatDataForTicketTableDateRows(IEnumerable<Ticket> tickets);
    IEnumerable<Ticket> GetTickets(Event Event);
    Ticket GetTicket(int id);
}