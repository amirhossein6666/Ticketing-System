using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.Dtos.CustomerDtos;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.CustomerUseCase;

namespace TicketingCleanArchitecture.PresentationLayer.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerController: ControllerBase
{
    private readonly CustomerSIgnUpUseCase _customerSIgnUpUseCase;
    private readonly GetCustomerByIdUesCase _getCustomerByIdUesCase;

    public CustomerController(CustomerSIgnUpUseCase customerSIgnUpUseCase, GetCustomerByIdUesCase getCustomerByIdUesCase)
    {
        _customerSIgnUpUseCase = customerSIgnUpUseCase;
        _getCustomerByIdUesCase = getCustomerByIdUesCase;
    }
    [HttpPost]
    public async Task<IActionResult> CustomerSignUp(CustomerSignupDto customerDto)
    {
        var customer = await _customerSIgnUpUseCase.Execute(customerDto);
        return Ok(customer);
    }

    [HttpGet]
    public async Task<IActionResult> GetCustomerById(int id)
    {
        var customer = await _getCustomerByIdUesCase.Execute(id);
        return Ok(customer);
    }
}