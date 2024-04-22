namespace TicketToRide.Interface;

public interface ICity
{
    string Name { get; }
    IEnumerable<IRoute> Routes { get; }
}
