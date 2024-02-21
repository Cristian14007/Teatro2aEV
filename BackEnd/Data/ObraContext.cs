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

            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

          

            modelBuilder.Entity<Asiento>()
                .HasOne(a => a.User)
                .WithMany(u => u.Asientos)
                .HasForeignKey(a => a.UserId);

          
            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Obra)
                .WithMany(o => o.Sesiones)
                .HasForeignKey(s => s.ObraId);

          
            modelBuilder.Entity<Asiento>()
                .HasOne(a => a.Sesion)
                .WithMany(s => s.Asientos)
                .HasForeignKey(a => a.SesionId)
                 .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Obra> Obras {get; set;}

        public DbSet<Asiento> Asientos {get; set;}

        public DbSet<Sesion> Sesiones {get; set;}

        public DbSet<User> Usuarios {get; set;}
    }
}