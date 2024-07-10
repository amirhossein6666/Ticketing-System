using TicketingCleanArchitecture.ApplicationLayer.Dtos.TicketDtos;
using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;

public class UpdateTicketUseCase
{
    private readonly ITicketRepository _ticketRepository;

    public UpdateTicketUseCase(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<Ticket> Execute(UpdateTicketDto updateTicketDto, int id)
    {
        var ticket = await _ticketRepository.GetTicketById(id);
        ticket.Title = updateTicketDto.Title;
        ticket.Message = updateTicketDto.Message;
        ticket.Status = updateTicketDto.Status;
        ticket.Rating = updateTicketDto.Rating;
        return await _ticketRepository.UpdateTicket(ticket);
    }
}