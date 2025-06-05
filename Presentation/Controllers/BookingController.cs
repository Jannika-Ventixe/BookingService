using Microsoft.AspNetCore.Mvc;
using Presentation.Models;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController(IBookingService bookingService) : ControllerBase
{
    private readonly IBookingService _bookingService = bookingService;

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookingRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var result = await _bookingService.CreateBookingAsync(request);
        return result.Success
            ? Ok()
            : StatusCode(StatusCodes.Status500InternalServerError, "Unable to create booking.");

    }
}
