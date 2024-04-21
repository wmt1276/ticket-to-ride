using TicketToRide.Interfaces;

namespace TicketToRide.Dtos
{
    public class DestinationTicketDto : IDestinationTicket
    {
        public string[] Cities { get; set; }
        public int Points { get; set; }
    }
}