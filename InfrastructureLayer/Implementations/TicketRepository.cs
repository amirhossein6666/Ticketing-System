using Microsoft.EntityFrameworkCore;
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

    public async Task<Ticket> GetTicketById(int id)
    {
         return await _appDbContext.Tickets.Include(t => t.Customer).FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Ticket> UpdateTicket(Ticket updatedTicket)
    {
        _appDbContext.Tickets.Update(updatedTicket);
        await _appDbContext.SaveChangesAsync();
        return updatedTicket;
    }

    public async Task<Ticket> RemoveTicket(int Id)
    {
        Ticket ticket = await _appDbContext.Tickets.FindAsync(Id);
        _appDbContext.Tickets.Remove(ticket);
        await _appDbContext.SaveChangesAsync();
        return ticket;
    }

    public async Task<IEnumerable<Ticket>> FindAllTickets()
    {
        return await _appDbContext.Tickets.ToListAsync();
    }
}