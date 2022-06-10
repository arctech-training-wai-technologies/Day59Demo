using Microsoft.EntityFrameworkCore;

namespace Day59DemoCodeFirst.Models.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    { }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
}