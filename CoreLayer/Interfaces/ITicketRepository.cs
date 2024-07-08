
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ITicketRepository
{
    Task<Ticket> AddTicket(Ticket ticket);
    Ticket GetTicketById(int Id);
    Ticket UpdateTicket(Ticket ticket);
    Ticket RemoveTicket(int Id);
    IEnumerable<Ticket> FindAllTickets();
}