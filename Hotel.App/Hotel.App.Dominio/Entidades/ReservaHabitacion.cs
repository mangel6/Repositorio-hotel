using System;

namespace Hotel.App.Dominio
{
    public class ReservaHabitacion
    {
        public int Id {get; set;}
        public int ReservaId {get; set;}
        public int HabitacionId {get; set;}

        public Reserva Reserva {get; set;}
        public Habitacion Habitacion {get; set;}
    }
}