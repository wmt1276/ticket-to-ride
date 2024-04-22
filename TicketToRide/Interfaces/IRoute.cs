namespace TicketToRide.Interfaces 
{
    public interface IRoute 
    {
        string[] Cities { get; }

        int Length { get; }

        string[] Colors { get; }
    }
}