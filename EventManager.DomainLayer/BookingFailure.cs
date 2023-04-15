namespace EventManager.DomainLayer;

public class BookingFailure : Exception
{
    public BookingFailure(string? message) : base(message)
    {
    }
}