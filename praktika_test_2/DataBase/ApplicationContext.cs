using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=dashboard_contract;Username=postgres;Password=AzmovlHype");
    }
}

public class User
{
    [Key]
    public int user_id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}