
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ITicketRepository
{
    Task<Ticket> AddTicket(Ticket ticket);
    Task<Ticket> GetTicketById(int Id);
    Task<Ticket> UpdateTicket(Ticket updatedTicket);
    Task<Ticket> RemoveTicket(int Id);
    Task<IEnumerable<Ticket>> FindAllTickets();
}