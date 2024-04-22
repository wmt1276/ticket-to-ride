namespace TicketToRide.Interface;

public interface IDestinationTicket
{
    Tuple<string, string> Cities { get; }
    int Points { get; }
}