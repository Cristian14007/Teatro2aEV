using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Data{

    public class ObraContext : DbContext
    {
        public ObraContext(DbContextOptions<ObraContext> options)
            : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Obra>()
        .HasKey(ob => new { ob.ObraId });

    /* modelBuilder.Entity<Obra>()
        .HasOne(pi => pi.Pizza)
        .WithMany(p => p.PizzaIngredientes)
        .HasForeignKey(pi => pi.PizzaId);

    modelBuilder.Entity<PizzaIngrediente>()
        .HasOne(pi => pi.Ingrediente)
        .WithMany(i => i.PizzaIngredientes)
        .HasForeignKey(pi => pi.IngredienteId); */

modelBuilder.Entity<Obra>().HasData(
    new Obra { ObraId = 1, Titulo = "Piña" },
    new Obra { ObraId = 2, Titulo = "Jamón york" },
    new Obra { ObraId = 3, Titulo = "Carne picada" }
);


        }

        public DbSet<Obra> Obras {get; set;}
    }
}