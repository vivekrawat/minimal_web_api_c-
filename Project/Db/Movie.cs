using Microsoft.EntityFrameworkCore;

namespace DbStuff
{
  class Movie : DbContext
  {
    public Movie(DbContextOptions<Movie> options) : base(options)
    {
    }
    
    public DbSet<Models.Movie> Movies => Set<Models.Movie>();
    
  }
}