using Microsoft.EntityFrameworkCore;
using Presentation.Data.Entities;

namespace Presentation.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<BookingEntity> Bookings { get; set; }
}
