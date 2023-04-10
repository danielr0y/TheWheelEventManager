namespace WebApp.Models;

public class AllEventsViewModel
{
    public AllEventsViewModel(
        string heading,
        // ILayoutViewModel layoutViewModel,
        // SearchPartialViewModel searchPartialViewModel,
        EventsPartialViewModel events
    )
    {
        // IsAuthenticated = layoutViewModel.IsAuthenticated;
        // IsAdmin = layoutViewModel.IsAdmin;
        // Messages = layoutViewModel.Messages;
        // NumberOfMessages = layoutViewModel.NumberOfMessages;
        // LoginForm = layoutViewModel.LoginForm;
        // SearchPartialViewModel = searchPartialViewModel;

        Heading = heading;
        Events = events;
    }
    // parent template items
    // public bool IsAuthenticated { get; }
    // public bool IsAdmin { get; }
    // public IEnumerable<MessageViewModel> Messages { get; }
    // public int NumberOfMessages { get; }
    // public LoginFormPartialViewModel LoginForm { get; }

    // search box
    // public SearchPartialViewModel SearchPartialViewModel { get; }

    public string Heading { get; }
    // events
    public EventsPartialViewModel Events { get; }
}