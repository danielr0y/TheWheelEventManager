using EventManager.DomainLayer;

namespace EventManager.DataLayer;

public class TempBookingRepository : IBookingRepository
{
    private readonly List<Booking> _bookings;

    public TempBookingRepository()
    {
        _bookings = new List<Booking>();
    }

    public void Book(Customer customer, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate)
    {
        _bookings.Add(
            new Booking(
                1,
                customer,
                ticket,
                qty,
                purchasePrice,
                purchaseDate));
    }
}