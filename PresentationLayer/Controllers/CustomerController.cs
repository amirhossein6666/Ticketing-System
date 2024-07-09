using Microsoft.AspNetCore.Mvc;
using TicketingCleanArchitecture.ApplicationLayer.UseCases.CustomerUseCase;
using TicketingCleanArchitecture.CoreLayer.Dtos;

namespace TicketingCleanArchitecture.PresentationLayer.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerController: ControllerBase
{
    private readonly CustomerSIgnUpUseCase _customerSIgnUpUseCase;

    public CustomerController(CustomerSIgnUpUseCase customerSIgnUpUseCase)
    {
        _customerSIgnUpUseCase = customerSIgnUpUseCase;
    }
    [HttpPost]
    public async Task<IActionResult> CustomerSignUp(CustomerSignupDto customerDto)
    {
        var customer = await _customerSIgnUpUseCase.Execute(customerDto);
        return Ok(customer);
    }
}