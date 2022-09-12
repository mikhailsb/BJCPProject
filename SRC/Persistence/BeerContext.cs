
using Microsoft.EntityFrameworkCore;
using SRC.Models;

namespace SRC.Persistence;

public class BeerContext : DbContext
{

    public BeerContext(DbContextOptions<BeerContext> obtions, IConfiguration configuration) : base(obtions)
    {
        this.strConnection = configuration.GetConnectionString("DefaultConnection");
    }
    string strConnection { get; set; }
    public IConfiguration Configuration { get; private set; }
    public DbSet<Estilo> Estilos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estilo>()
        .HasKey(a => a.Id);

        modelBuilder.Entity<Estilo>()
        .Property( a => a.ABV)
            .HasPrecision(4,2);
        
        modelBuilder.Entity<Estilo>()
        .HasData(new Estilo { Id = 1, Nome = "American Light Lager", ABV = 4.2M, IBU = 12, SRM = 3 },
                 new Estilo { Id = 2, Nome = "American Lager", ABV = 5.3M, IBU = 18, SRM = 4 });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(strConnection);
    }
}