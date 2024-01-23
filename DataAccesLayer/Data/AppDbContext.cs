using DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Client> Clients { get; set; }
}
