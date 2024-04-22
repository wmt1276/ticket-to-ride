using TicketToRide.Interfaces;

namespace TicketToRide.Dtos;

public class RouteDto
{
    public string[] Cities { get; set; }
    public int Length { get; set; }
    public string[] Colors { get; set; }
}
