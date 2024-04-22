using TicketToRide.Dto;
using System.Text.Json;

List<DestinationTicketDto> destinationTickets = Deserialize<List<DestinationTicketDto>>("Data/USA/DestinationTickets/Vanilla.json");
BoardDto board = Deserialize<BoardDto>("Data/USA/Board.json");

List<string> cities = [];

foreach (RouteDto route in board.Routes)
{
    cities.AddRange(route.Cities);
}

cities = cities.Distinct().ToList();
cities.Sort();

Console.WriteLine($"Cities: {cities.Count}");
foreach (string city in cities)
{
    Console.WriteLine(city);
}

static T Deserialize<T>(string fileName)
{
    string jsonString = File.ReadAllText(fileName);
    return JsonSerializer.Deserialize<T>(jsonString)!;
}