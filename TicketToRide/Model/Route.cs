using TicketToRide.Dto;
using TicketToRide.Interface;

namespace TicketToRide.Model;

public class Route(RouteDto dto) : IRoute
{
    public IEnumerable<string> Cities { get; } = dto.Cities;
    public int Length { get; } = dto.Length;
    public IEnumerable<string> Colors { get; } = dto.Colors;
}
