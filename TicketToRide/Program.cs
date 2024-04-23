using TicketToRide.Dto;
using System.Text.Json;
using TicketToRide.Interface;
using TicketToRide.Model;

List<DestinationTicketDto> destinationTickets = Deserialize<List<DestinationTicketDto>>("Data/USA/DestinationTickets/Vanilla.json");
BoardDto board = Deserialize<BoardDto>("Data/USA/Board.json");

IEnumerable<IRoute> routes = board.Routes.Select(route => new Route(route));

Dictionary<string, ICity> cities = new Dictionary<string, ICity>();

foreach (IRoute route in routes)
{
    foreach (string cityName in route.Cities)
    {
        if (cities.TryGetValue(cityName, out ICity? city))
        {
            city.Routes.Add(route);
        }
        else
        {
            cities[cityName] = new City(cityName, [route]);
        }
    }
}

Console.WriteLine($"City Count: {cities["Los Angeles"].Routes.Count}");

static T Deserialize<T>(string fileName)
{
    string jsonString = File.ReadAllText(fileName);
    return JsonSerializer.Deserialize<T>(jsonString)!;
}