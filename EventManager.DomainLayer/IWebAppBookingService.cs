namespace EventManager.DomainLayer;

public interface IWebAppBookingService
{
    void Book(Customer customer, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate);
}