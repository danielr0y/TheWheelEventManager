namespace EventManager.DomainLayer;

public class ReleasingGondolasCausedOutOfRangeException : Exception
{
    public ReleasingGondolasCausedOutOfRangeException(int remainingGondolas, int qty)
    {
        RemainingGondolas = remainingGondolas;
        Qty = qty;
    }

    public int RemainingGondolas { get; }
    public int Qty { get; }
}