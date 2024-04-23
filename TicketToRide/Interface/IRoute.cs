namespace TicketToRide.Interface;

public interface IRoute 
{
    IEnumerable<string> Cities { get; }
    int Length { get; }
    IEnumerable<string> Colors { get; }
}