namespace EventManager.DomainLayer;

public class InsufficientGondolasRemaining : Exception
{
    public InsufficientGondolasRemaining(int remainingGondolas)
    {
        RemainingGondolas = remainingGondolas;
    }

    public int RemainingGondolas { get; }
}