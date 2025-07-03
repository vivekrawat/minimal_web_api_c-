using Microsoft.EntityFrameworkCore;
namespace DbStuff
{
  class User : DbContext
  {
    public User(DbContextOptions<User> options) : base(options)
    {
    }
    public DbSet<Models.User> Users => Set<Models.User>();
  }
}