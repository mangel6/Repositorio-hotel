using Microsoft.EntityFrameworkCore;
using Hotel.App.Dominio;

namespace Hotel.App.Persistencia
{
    public class AppContext: DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}

        public DbSet<Reserva> Reservas {get; set;}

        public DbSet<Habitacion> Habitaciones {get; set;}
        public DbSet<ReservaHabitacion> ReservaHabitacion {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=HotelData75");
            }
        }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //Inactivar el borrado en una relación 1=>N    Usuario => Reserva
           modelBuilder.Entity<Usuario>()
            .HasMany( u => u.ListaReservas)
            .WithOne(r => r.Usuario)
            .OnDelete(DeleteBehavior.Restrict);
            //.OnDelete(DeleteBehavior.Cascade);

            //Inactivar el borrado en cascada N=>N entre HAbitacion => Reserva
            //modelBuilder.Entity<ReservaHabitacion>().HasKey(rh => new {rh.ReservaId, rh.HabitacionId});

            //Inactivamos borrado en cascada en reserva para la relacion entre Reserva => ReservaHabitación
           /* modelBuilder.Entity<Reserva>()
                .HasMany(r => r.ReservasHabitaciones)
                .WithOne(rh => rh.Reserva)
                .OnDelete(DeleteBehavior.Restrict);*/

        }
    }
}