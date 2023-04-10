namespace EventManager.DomainLayer;

public class TicketService : IWebAppTicketService
{
    private readonly ITicketRepository _repository;

    public TicketService(ITicketRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public IEnumerable<TimeOnly> FormatDataForTicketTableTimeRow(IEnumerable<Ticket> tickets)
    {
        var ticketsGrouped =
            from ticket in tickets
            orderby ticket.DateTime
            group ticket by TimeOnly.FromDateTime(ticket.DateTime);

        return ticketsGrouped.Select(ticket => ticket.Key);
    }

    public IEnumerable<IGrouping<DateOnly, Ticket>> FormatDataForTicketTableDateRows(IEnumerable<Ticket> tickets) =>
        from ticket in tickets
        orderby ticket.DateTime
        group ticket by DateOnly.FromDateTime(ticket.DateTime);

    public IEnumerable<Ticket> GetTickets(Event Event) => _repository.GetTickets(Event);
}