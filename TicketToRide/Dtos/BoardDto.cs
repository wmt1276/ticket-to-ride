﻿using TicketToRide.Interfaces;

namespace TicketToRide.Dtos;

public class BoardDto
{
    public string Location { get; set; }
    public RouteDto[] Routes { get; set; }
}
