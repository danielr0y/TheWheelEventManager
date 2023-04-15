namespace EventManager.DomainLayer;

public class Customer : IUser
{
    public Customer(int id, decimal budget = 500)
    {
        Id = id;
        Budget = budget;
    }

    public int Id { get; }
    public UserType Type => UserType.Customer;
    public decimal Budget { get; }

    public void Purchase(IWebAppBookingService bookingService, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate)
    {
        if (!WithinBudget(ticket.Price * qty))
        {
            throw new PurchaseExceedsCustomerBudget(Budget);
        }

        bookingService.Book(this, ticket, qty, purchasePrice, purchaseDate);
    }

    private bool WithinBudget(decimal purchasePrice) => (purchasePrice <= Budget);
}