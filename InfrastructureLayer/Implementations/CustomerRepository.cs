using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.CoreLayer.Dtos;
using TicketingCleanArchitecture.CoreLayer.Entities;
using TicketingCleanArchitecture.CoreLayer.Interfaces;
using TicketingCleanArchitecture.InfrastructureLayer.Data;

namespace TicketingCleanArchitecture.InfrastructureLayer.Implementations;

public class CustomerRepository: ICustomerRepository
{
    private readonly AppDbContext _appDbContext;

    public CustomerRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Customer> CustomerSignUp(CustomerSignupDto customerDto)
    {
        var customer = new Customer()
        {
            Name = customerDto.Name,
            UserName = customerDto.UserName,
            PassWord = customerDto.PassWord,
            Tickets = new List<Ticket>(),
        };
        _appDbContext.Customers.Add(customer);
        await _appDbContext.SaveChangesAsync();
        return customer;
    }
}