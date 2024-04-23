namespace TicketToRide.Interface;

public interface IDestinationTicket
{
    IEnumerable<string> Cities { get; }
    int Points { get; }
}