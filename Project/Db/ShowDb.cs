using Microsoft.EntityFrameworkCore;


namespace DbStuff
{
  class Show : DbContext
  {
    public Show(DbContextOptions<Show> options) : base(options)
    {
    }
    public DbSet<Models.Show> Shows => Set<Models.Show>();
  }
}