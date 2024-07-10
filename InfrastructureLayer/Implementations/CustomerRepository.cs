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
    public async Task<Customer> CustomerSignUp(Customer customer)
    {
        _appDbContext.Customers.Add(customer);
        await _appDbContext.SaveChangesAsync();
        return customer;
    }
}