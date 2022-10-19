using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base (options) {

    }   

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Book>()
            .HasOne(e => e.Author)
            .WithMany(e => e.Books)
            .IsRequired(false);

        builder.Entity<Book>()
            .HasOne(e => e.editorial)
            .WithMany(e => e.Books)
            .IsRequired(false);

         builder.Entity<cliente>()
            .HasMany(e => e.prestamos)
            .WithOne(e => e.clientes)
            .IsRequired(false);
    }
    public DbSet<Book> Books { get; set; } = default!;

    public DbSet<Author> Authors { get; set; } = default!;

     public DbSet<editorial> editorial { get; set; } = default!;

     public DbSet<cliente> cliente { get; set; } = default!;

     public DbSet<prestamo> prestamo { get; set; } = default!;

}