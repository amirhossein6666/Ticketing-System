using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;

namespace TicketingCleanArchitecture.ApplicationLayer.UseCases.CustomerUseCase;

public class GetCustomerByIdUesCase
{
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerByIdUesCase(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer> Execute(int id)
    {
        return await _customerRepository.GetCustomerById(id);
    }
}