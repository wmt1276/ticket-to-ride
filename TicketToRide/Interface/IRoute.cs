namespace TicketToRide.Interface;

public interface IRoute 
{
    Tuple<string, string> Cities { get; }
    int Length { get; }
    IEnumerable<string> Colors { get; }
}