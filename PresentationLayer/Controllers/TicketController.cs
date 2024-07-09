using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;
using TicketingCleanArchitecture.CoreLayer.Dtos;
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.PresentationLayer.Controllers;
[ApiController]
[Route("[controller]")]
public class TicketController: ControllerBase
{
    private readonly AddTicketUseCase _addTicketUseCase;
    private readonly GetTicketByIdUseCase _getTicketByIdUseCase;

    public TicketController(AddTicketUseCase addTicketUseCase, GetTicketByIdUseCase getTicketByIdUseCase)
    {
        _addTicketUseCase = addTicketUseCase;
        _getTicketByIdUseCase = getTicketByIdUseCase;
    }

    [HttpPost]
    public async Task<Ticket> AddTicket(CreateTicketDto ticketDto)
    {
        return await _addTicketUseCase.Execute(ticketDto);
    }
    [HttpGet("id")]
    public async Task<Ticket> GetTicketById(int id)
    {
        return await _getTicketByIdUseCase.Execute(id);
    }
}