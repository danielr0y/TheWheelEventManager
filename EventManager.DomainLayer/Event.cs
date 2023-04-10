namespace EventManager.DomainLayer;

public class Event
{
    public int Id { get; }
    public string Name { get; }
    public string Excerpt { get; }
    public string Description { get; }
    public string Category { get; }
    public Status Status { get; }
    // public IEnumerable<Ticket> Tickets { get; }
    // public IEnumerable<Review> Reviews { get; }
    public string ImageURL { get; }

    public Event(
        int id = 123,
        string name = "Name",
        string excerpt = "Excerpt",
        string description = "Description",
        string category = "Category",
        Status status = Status.Upcoming,
        // IEnumerable<Tickets> tickets = Array.Empty<Ticket>(),
        // IEnumerable<Reviews> reviews = Array.Empty<Ticket>(),
        string imageURL = "ImageURL"
    )
    {
        Id = id;
        Name = name;
        Excerpt = excerpt;
        Description = description;
        Category = category;
        Status = status;
        // Tickets = tickets;
        // Reviews = reviews;
        ImageURL = imageURL;
    }
}