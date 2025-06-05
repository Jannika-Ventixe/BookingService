using Presentation.Data.Entities;
using Presentation.Data.Repositories;
using Presentation.Models;

namespace Presentation.Services;

public class BookingService(IBookingRepository bookingrepository) : IBookingService
{
    private readonly IBookingRepository _bookingrepository = bookingrepository;

    public async Task<BookingResult> CreateBookingAsync(CreateBookingRequest request)
    {
        var bookingEntity = new BookingEntity
        {
            RoomId = request.RoomId,
            CustomerName = request.CustomerName,
            StartDate = request.StartDate,
            EndDate = request.EndDate

        };
        var result = await _bookingrepository.AddAsync(bookingEntity);
        return result.Success
            ? new BookingResult { Success = true }
            : new BookingResult { Success = false, Error = result.Error };

    }
}
