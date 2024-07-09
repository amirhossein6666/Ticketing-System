using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.CoreLayer.Dtos;
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.CoreLayer.Interfaces;

public interface ICustomerRepository
{
     Task<Customer> CustomerSignUp(CustomerSignupDto customerDto);
}