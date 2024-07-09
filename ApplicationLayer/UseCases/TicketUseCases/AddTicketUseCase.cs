using TicketingCleanArchitecture.CoreLayer.Dtos;
using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;

public class AddTicketUseCase
{
    private readonly ITicketRepository _ticketRepository;

    public AddTicketUseCase(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<Ticket> Execute(CreateTicketDto ticketDto)
    {
        return await _ticketRepository.AddTicket(ticketDto);
    }
}