using TicketToRide.Interfaces;
using TicketToRide.Dtos;
using System.Text.Json;

string destinationTicketFileName = "Data/USA/DestinationTickets/Vanilla.json";
string destinationTicketjsonString = File.ReadAllText(destinationTicketFileName);
List<DestinationTicketDto> destinationTickets = JsonSerializer.Deserialize<List<DestinationTicketDto>>(destinationTicketjsonString)!;

Console.WriteLine(destinationTickets.Count);