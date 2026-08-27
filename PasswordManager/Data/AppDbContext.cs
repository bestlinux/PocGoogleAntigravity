using Microsoft.EntityFrameworkCore;
using PasswordManager.Data.Models;

namespace PasswordManager.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<PasswordEntry> PasswordEntries { get; set; }
}
