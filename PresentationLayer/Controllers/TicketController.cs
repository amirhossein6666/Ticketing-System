using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.Dtos;
using TicketingCleanArchitecture.ApplicationLayer.Dtos.TicketDtos;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;

namespace TicketingCleanArchitecture.PresentationLayer.Controllers;
[ApiController]
[Route("[controller]")]
public class TicketController: ControllerBase
{
    private readonly AddTicketUseCase _addTicketUseCase;
    private readonly GetTicketByIdUseCase _getTicketByIdUseCase;
    private readonly UpdateTicketUseCase _updateTicketUseCase;

    public TicketController(AddTicketUseCase addTicketUseCase, GetTicketByIdUseCase getTicketByIdUseCase, UpdateTicketUseCase updateTicketUseCase)
    {
        _addTicketUseCase = addTicketUseCase;
        _getTicketByIdUseCase = getTicketByIdUseCase;
        _updateTicketUseCase = updateTicketUseCase;
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

    [HttpPatch("id")]
    public async Task<IActionResult> UpdateTicket(UpdateTicketDto updateTicketDto, int id)
    {
        var ticket = await _updateTicketUseCase.Execute(updateTicketDto, id);
        return Ok(ticket);
    }
}