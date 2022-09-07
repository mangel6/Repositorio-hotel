using Hotel.App.Dominio;

namespace Hotel.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        Usuario AddUsuario(Usuario usuario);  //firma del metodo

        void DeleteUsuario(int idUsuario);

        Usuario getUsuario(int idUsuario);

        IEnumerable<Usuario> GetAllUsuarios();

        Usuario UpdateUsuario(Usuario usuario);

        void Saludo();
    }

}