
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ITicketRepository
{
    Ticket AddTicket(Ticket ticket);
    Ticket GetTicketById(int Id);
}