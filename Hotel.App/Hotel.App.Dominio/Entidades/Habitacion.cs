using System;

namespace Hotel.App.Dominio
{
    public class Habitacion
    {
        public int Id {get; set;}
        public int Numero {get; set;}

        public int camas {get; set;}

        public List<ReservaHabitacion> ReservasHabitaciones {get; set;}

    }
}