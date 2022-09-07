using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.App.Dominio
{
    public class Usuario
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "El campo Login es obligatorio")]
        public string Login {get; set;}

        [Required(ErrorMessage = "El campo Login es obligatorio")]
        public string Password {get; set;}

        [Required(ErrorMessage = "El campo Login es obligatorio")]
        public string Email {get; set;}

        public DateTime FechaAlta{get; set;}
        
        public DateTime UltimoAcceso {get; set;}

        public List<Reserva> ListaReservas {get; set;}

    }
}