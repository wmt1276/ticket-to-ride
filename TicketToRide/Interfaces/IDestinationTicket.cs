namespace TicketToRide.Interfaces
{
    public interface IDestinationTicket
    {
        string[] Cities { get; }
        
        int Points { get; }
    }
}