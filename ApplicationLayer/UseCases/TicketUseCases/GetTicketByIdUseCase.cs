using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;

public class GetTicketByIdUseCase
{
    private readonly ITicketRepository _ticketRepository;

    public GetTicketByIdUseCase(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<Ticket> Execute(int Id)
    {
        return await _ticketRepository.GetTicketById(Id);
    }
}