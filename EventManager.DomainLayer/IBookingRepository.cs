namespace EventManager.DomainLayer;

public interface IBookingRepository
{
    void Book(Customer customer, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate);
}