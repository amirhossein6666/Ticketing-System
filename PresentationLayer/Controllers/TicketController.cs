using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;
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
    public async Task<Ticket> AddTicket(Ticket ticket)
    {
        return await _addTicketUseCase.Execute(ticket);
    }
    [HttpGet("Id")]
    public async Task<Ticket> GetTicketById(int Id)
    {
        return await _getTicketByIdUseCase.Execute(Id);
    }
}