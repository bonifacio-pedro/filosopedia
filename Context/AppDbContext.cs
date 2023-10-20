using FilosoPediaWeb.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FilosoPediaWeb.Api.Context;
public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt): base(opt) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Comentary> Comentaries { get; set; }
    public DbSet<Gender> Genders { get; set; }

}
