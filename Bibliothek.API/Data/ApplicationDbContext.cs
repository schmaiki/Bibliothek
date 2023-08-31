using Bibliothek.API.DataTypes;
using Bibliothek.API.Models.Ausweis;
using Bibliothek.API.Models.Author;
using Bibliothek.API.Models.Buch;
using Microsoft.EntityFrameworkCore;

namespace Bibliothek.API.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Buch> Buch { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Author> Author { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer($"Server=localhost; Database=Bibliothek; uid=sa; pwd=Maiki1511#; TrustServerCertificate=true");
    }
}