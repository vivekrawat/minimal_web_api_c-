using Microsoft.EntityFrameworkCore;

namespace DbStuff
{
  class Venue : DbContext
  {
    public Venue(DbContextOptions<Venue> options) : base(options)
    {
    }
    public DbSet<Models.Venue> Venues => Set<Models.Venue>();
  }
}