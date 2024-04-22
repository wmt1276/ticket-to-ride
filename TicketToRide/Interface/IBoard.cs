namespace TicketToRide.Interface
{
    public interface IBoard
    {
        string Location { get; }
        IRoute[] Routes { get; }
    }
}