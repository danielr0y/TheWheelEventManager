namespace EventManager.DomainLayer;

public class PurchaseExceedsCustomerBudget : Exception
{
    public PurchaseExceedsCustomerBudget(decimal budget)
    {
        Budget = budget;
    }

    public decimal Budget { get; }
}