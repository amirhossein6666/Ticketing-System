using TicketingCleanArchitecture.ApplicationLayer.Dtos.TicketDtos;
using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.TicketUseCases;

public class AddTicketUseCase
{
    private readonly ITicketRepository _ticketRepository;
    private readonly ICustomerRepository _customerRepository;

    public AddTicketUseCase(ITicketRepository ticketRepository, ICustomerRepository customerRepository)
    {
        _ticketRepository = ticketRepository;
        _customerRepository = customerRepository;
    }

    public async Task<Ticket> Execute(CreateTicketDto ticketDto)
    {
        var customer = await _customerRepository.GetCustomerById(ticketDto.CustomerId);
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
        return await _ticketRepository.AddTicket(ticket);
    }
}