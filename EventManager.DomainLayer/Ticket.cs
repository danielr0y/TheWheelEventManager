namespace EventManager.DomainLayer;

public class Ticket
{
    private int _remainingGondolas;

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

    public int RemainingGondolas
    {
        get => _remainingGondolas;
        private set
        {
            if (value is < 0 or > 42)
            {
                throw new ArgumentOutOfRangeException();
            }

            _remainingGondolas = value;
        }
    }

    public void ReserveGondolas(int qty)
    {
        try
        {
            RemainingGondolas -= qty;
        }
        catch (ArgumentOutOfRangeException e)
        {
            throw new InsufficientGondolasRemaining(RemainingGondolas);
        }
    }

    public void ReleaseGondolas(int qty)
    {
        try
        {
            RemainingGondolas += qty;
        }
        catch (ArgumentOutOfRangeException e)
        {
            throw new ReleasingGondolasCausedOutOfRangeException(RemainingGondolas, qty);
        }
    }
}