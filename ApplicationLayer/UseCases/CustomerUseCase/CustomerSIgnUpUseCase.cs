using TicketingCleanArchitecture.ApplicationLayer.Dtos.CustomerDtos;
using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.CustomerUseCase;

public class CustomerSIgnUpUseCase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerSIgnUpUseCase(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer> Execute(CustomerSignupDto customerDto)
    {
        var customer = new Customer()
        {
            Name = customerDto.Name,
            UserName = customerDto.UserName,
            PassWord = customerDto.PassWord,
            Tickets = new List<Ticket>(),
        };
        return await _customerRepository.CustomerSignUp(customer);
    }
}