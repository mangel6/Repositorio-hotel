using System;
using Hotel.App.Dominio;
using Hotel.App.Persistencia;

public class Program
{
    private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new Hotel.App.Persistencia.AppContext());

    private static void Main(string[] args)
    {
        Console.WriteLine("Hola mundo .NET");

        AdicionarUsuario();
        //BuscarUsuario();
        VerListadoUsuarios();
    }

    private static void AdicionarUsuario()
    {
        //Usuario usuario = new Usuario();
        var usuario = new Usuario();
        usuario.Login = "mintic2022";
        usuario.Password = "#$#$#$";
        usuario.Email = "minitic2022@ucaldas.com";
        usuario.FechaAlta = DateTime.Now;
        usuario.UltimoAcceso = DateTime.Now;

        _repositorioUsuario.AddUsuario(usuario);
        Console.WriteLine("Usuario Adicionado. ");
    }

    private static void BuscarUsuario()
    {
        Console.WriteLine("**************");
        Console.WriteLine("Buscando Usuario con ID 3");
        var usuario = _repositorioUsuario.getUsuario(3);
        Console.WriteLine("Login: " + usuario.Login);
        Console.WriteLine("email: " + usuario.Email);
    }

    public static void VerListadoUsuarios()
    {
        var listaUsuarios = _repositorioUsuario.GetAllUsuarios();
        foreach( var usu in listaUsuarios)
        {
            Console.WriteLine("Email: " + usu.Email);
        }
    }
}
