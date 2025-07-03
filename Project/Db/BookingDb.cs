using Microsoft.EntityFrameworkCore;

namespace DbStuff
{
  class Booking : DbContext
  {
    public Booking(DbContextOptions<Booking> options) : base(options)
    {
    }
    public DbSet<Models.Booking> Bookings => Set<Models.Booking>();
  }
}