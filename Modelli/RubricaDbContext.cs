using Microsoft.EntityFrameworkCore;
using Modelli.Models;

namespace Modelli;

public class RubricaDbContext : DbContext
{
    public RubricaDbContext(DbContextOptions<RubricaDbContext> options)
        : base(options)
    {
        // ...
    }

    public DbSet<Contatto> Contatti { get; set; } = null!;
}
