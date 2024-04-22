namespace TicketToRide.Interfaces;

public interface IBoard
{
    string Location { get; }

    IRoute[] Routes { get; }
}
