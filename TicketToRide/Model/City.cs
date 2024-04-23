using TicketToRide.Interface;

namespace TicketToRide.Model;

public class City(string name, IList<IRoute> routes) : ICity
{
    public string Name { get; } = name;
    public IList<IRoute> Routes { get; } = routes;
}
