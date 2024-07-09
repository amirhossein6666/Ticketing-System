using Microsoft.EntityFrameworkCore;
using TicketingCleanArchitecture.CoreLayer.Dtos;
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

    public async Task<Ticket> AddTicket(CreateTicketDto ticketDto)
    {
        var customer = await _appDbContext.Customers.FindAsync(ticketDto.CustomerId);
        if (customer == null)
        {
            throw new Exception("Customer Not Found");
        }
        var ticket = new Ticket()
        {
            Title = ticketDto.Title,
            Message = ticketDto.Message,
            SendDate = ticketDto.SendDate,
            Status = ticketDto.Status,
            Rating = ticketDto.Rating,
            Answers = new List<Answer>(),
            CustomerId = ticketDto.CustomerId,
            Customer = customer
        };
        _appDbContext.Tickets.Add(ticket);
        await _appDbContext.SaveChangesAsync();
        return ticket;
    }

    public async Task<Ticket> GetTicketById(int Id)
    {
         return await _appDbContext.Tickets.Include(t => t.Customer).FirstOrDefaultAsync();
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