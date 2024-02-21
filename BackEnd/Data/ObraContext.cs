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
    new Obra { ObraId = 1, Titulo = "Obra 1", Descripcion = "Desc obra 1", Genero = "Gen obra 1", Imagen ="Img obra 1"},
    new Obra { ObraId = 2, Titulo = "Obra 2", Descripcion = "Desc obra 2", Genero = "Gen obra 2", Imagen ="Img obra 2" },
    new Obra { ObraId = 3, Titulo = "Obra 3", Descripcion = "Desc obra 3", Genero = "Gen obra 3", Imagen ="Img obra 3" },
    new Obra { ObraId = 4, Titulo = "Obra 4", Descripcion = "Desc obra 4", Genero = "Gen obra 4", Imagen ="Img obra 4" },
    new Obra { ObraId = 5, Titulo = "Obra 5", Descripcion = "Desc obra 5", Genero = "Gen obra 5", Imagen ="Img obra 5" }
);



        }

        public DbSet<Obra> Obras {get; set;}
    }
}