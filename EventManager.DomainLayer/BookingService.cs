namespace EventManager.DomainLayer;

public class BookingService : IWebAppBookingService
{
    private readonly IBookingRepository _bookingRepository;

    public BookingService(IBookingRepository repository)
    {
        _bookingRepository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public void Book(Customer customer, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate)
    {
        ticket.ReserveGondolas(qty);

        try
        {
            _bookingRepository.Book(customer, ticket, qty, purchasePrice, purchaseDate);
        }
        catch (Exception e)
        {
            ticket.ReleaseGondolas(qty);

            throw new BookingFailure("The booking was not able to be recorded.");
        }
    }
}