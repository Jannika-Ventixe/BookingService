namespace Presentation.Models;

public class CreateBookingRequest
{
    public string RoomId { get; set; } = null!;
    public string Image { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; } 
}