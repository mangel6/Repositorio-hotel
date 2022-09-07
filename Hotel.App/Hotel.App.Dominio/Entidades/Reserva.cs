using System;

namespace Hotel.App.Dominio
{
    public class Reserva
    {
        public int Id {get; set;}
        public DateTime FechaInicio {get; set;}
        public DateTime FechaFin {get; set;}
        public int Precio {get; set;}
        public string Ocupacion {get; set;}
        public string NombreTomador {get; set;}

        public int UsuarioId {get; set;}

        public Usuario Usuario {get; set; }

        public List<ReservaHabitacion> ReservasHabitaciones {get; set;}
    }
}