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
        _appDbContext.Add(ticket);
        await _appDbContext.SaveChangesAsync();
        return ticket;
    }

    public Ticket GetTicketById(int Id)
    {

    }

    public Ticket UpdateTicket(Ticket ticket)
    {

    }

    public Ticket RemoveTicket(int Id)
    {

    }
}