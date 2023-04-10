namespace WebApp.Models;

public class HomeViewModel
{
    // public bool IsAuthenticated { get; }
    // public bool IsAdmin { get; }
    // public IEnumerable<MessageViewModel> Messages { get; }
    // public int NumberOfMessages { get; }
    // public LoginFormPartialViewModel LoginForm { get; }
    // public SearchPartialViewModel Search { get; }

    public string Heading { get; }
    // the events
    public EventsPartialViewModel UpcomingEvents { get; }
    public EventsPartialViewModel CancelledEvents { get; }

    public HomeViewModel(
        // ILayoutViewModel layoutViewModel,
        // SearchPartialViewModel search,
        string heading,
        EventsPartialViewModel upcomingEvents,
        EventsPartialViewModel cancelledEvents
    )
    {
        // IsAuthenticated = layoutViewModel.IsAuthenticated;
        // IsAdmin = layoutViewModel.IsAdmin;
        // Messages = layoutViewModel.Messages;
        // NumberOfMessages = layoutViewModel.NumberOfMessages;
        // LoginForm = layoutViewModel.LoginForm;
        // Search = search;

        Heading = heading;
        UpcomingEvents = upcomingEvents;
        CancelledEvents = cancelledEvents;
    }
}