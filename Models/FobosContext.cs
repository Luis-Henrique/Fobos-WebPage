using Microsoft.EntityFrameworkCore;
namespace Fobos.Models;
public class FobosContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Post> Posts { get; set; }

    public FobosContext(DbContextOptions<FobosContext> options) : base(options)
    {
        
    }
}