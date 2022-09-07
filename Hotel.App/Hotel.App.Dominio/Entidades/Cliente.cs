namespace Hotel.App.Dominio
{
    public class Cliente: Usuario
    {
        public string Nombres { get; set;}
        public string Apellidos {get; set;}
        public string Nif {get; set;}
        public string Domicilio {get; set;}
        public string Poblacion {get; set;}
        public string Provincia {get; set;}
        public string CodigoPostal {get; set;}
        public string Telefono {get; set;}
    }
}