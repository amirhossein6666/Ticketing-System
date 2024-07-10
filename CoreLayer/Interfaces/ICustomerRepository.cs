using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ICustomerRepository
{
     Task<Customer> CustomerSignUp(Customer customer);
     Task<Customer> GetCustomerById(int Id);
}