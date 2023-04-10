namespace EventManager.DomainLayer;

public class Ticket
{
    public Ticket(
        int id,
        Event Event,
        DateTime dateTime = new DateTime(),
        decimal price = 120,
        int remainingGondolas = 24
    )
    {
        Id = id;
        this.Event = Event;
        DateTime = dateTime;
        Price = price;
        RemainingGondolas = remainingGondolas;
    }

    public int Id { get; }
    public Event Event { get; }
    public DateTime DateTime { get; }
    // [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; }
    public int RemainingGondolas { get; }
}