using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;
using TicketingCleanArchitecture.InfrastructureLayer.Data;

namespace TicketingCleanArchitecture.InfrastructureLayer.Implementations;

public class TicketRepository : ITicketRepository
{
    private readonly AppDbContext _appDbContext;

    public TicketRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<Ticket> AddTicket(Ticket ticket)
    {
        _appDbContext.Tickets.Add(ticket);
        await _appDbContext.SaveChangesAsync();
        return ticket;
    }

    public async Task<Ticket> GetTicketById(int Id)
    {
        return await _appDbContext.Tickets.FindAsync(Id);
    }

    public async Task<Ticket> UpdateTicket(Ticket updatedTicket)
    {
        _appDbContext.Tickets.Update(updatedTicket);
        await _appDbContext.SaveChangesAsync();
        return updatedTicket;
    }

    public Ticket RemoveTicket(int Id)
    {

    }

    public IEnumerable<Ticket> FindAllTickets()
    {

    }
}