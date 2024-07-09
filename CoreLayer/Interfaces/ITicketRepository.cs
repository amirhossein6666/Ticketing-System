
using TicketingCleanArchitecture.CoreLayer.Dtos;
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ITicketRepository
{
    Task<Ticket> AddTicket(CreateTicketDto ticektDto);
    Task<Ticket> GetTicketById(int Id);
    Task<Ticket> UpdateTicket(Ticket updatedTicket);
    Task<Ticket> RemoveTicket(int Id);
    Task<IEnumerable<Ticket>> FindAllTickets();
}