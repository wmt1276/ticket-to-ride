namespace TicketToRide.Interface;

public interface ICity
{
    string Name { get; }
    IList<IRoute> Routes { get; }
}
