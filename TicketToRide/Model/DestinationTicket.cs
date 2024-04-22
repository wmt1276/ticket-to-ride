using TicketToRide.Dto;
using TicketToRide.Interface;

namespace TicketToRide.Model;

public class DestinationTicket(DestinationTicketDto dto) : IDestinationTicket
{
    public Tuple<string, string> Cities { get; } = new Tuple<string, string>(dto.Cities[0], dto.Cities[1]);

    public int Points { get; } = dto.Points;
}
