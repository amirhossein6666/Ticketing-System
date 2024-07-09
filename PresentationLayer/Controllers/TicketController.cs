using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;
using TicketingCleanArchitecture.CoreLayer.Dtos;

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
    public async Task<IActionResult> AddTicket(CreateTicketDto ticketDto)
    {
        var ticket = await _addTicketUseCase.Execute(ticketDto);
        return Ok(ticket);
    }
    [HttpGet("id")]
    public async Task<IActionResult> GetTicketById(int id)
    {
        return Ok(await _getTicketByIdUseCase.Execute(id));
    }
}