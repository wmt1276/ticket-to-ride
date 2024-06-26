﻿using TicketToRide.Dto;
using TicketToRide.Interface;

namespace TicketToRide.Model;

public class DestinationTicket(DestinationTicketDto dto) : IDestinationTicket
{
    public IEnumerable<string> Cities { get; } = dto.Cities;
    public int Points { get; } = dto.Points;
}
