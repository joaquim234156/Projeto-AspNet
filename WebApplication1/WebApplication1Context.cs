using Microsoft.EntityFrameworkCore;

public class WebApplication1Context(DbContextOptions<WebApplication1Context> options) : DbContext(options)
{
    public DbSet<WebApplication1.Models.Department> Department { get; set; } = default!;
}
