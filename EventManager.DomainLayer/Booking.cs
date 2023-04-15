namespace EventManager.DomainLayer;

public class Booking
{
    public Booking(int id, Customer customer, Ticket ticket, int qty, decimal purchasePrice, DateTime purchaseDate)
    {
        Id = id;
        Customer = customer;
        Ticket = ticket;
        Qty = qty;
        PurchasePrice = purchasePrice;
        PurchaseDate = purchaseDate;
    }
    public int Id { get; }
    public Customer Customer { get; }
    public Ticket Ticket { get; }
    public int Qty { get; }

    // [Column(TypeName = "decimal(18, 2)")]
    public decimal PurchasePrice { get; }
    public DateTime PurchaseDate { get; }
}