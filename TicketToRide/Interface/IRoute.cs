namespace TicketToRide.Interface;

public interface IRoute 
{
    string[] Cities { get; }
    int Length { get; }
    string[] Colors { get; }
}