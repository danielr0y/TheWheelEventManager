namespace WebApp.Models;

public class TicketTableTimeRowViewModel
{
    public TicketTableTimeRowViewModel(IEnumerable<TicketTableTimeCellViewModel> times)
    {
        Times = times;
        NumberOfCells = Times.Count();
    }

    public IEnumerable<TicketTableTimeCellViewModel> Times { get; }
    public int NumberOfCells { get; }
}