using System;
using Hotel.App.Dominio;

namespace Hotel.App.Persistencia
{
    public class RepositorioUsuario: IRepositorioUsuario
    {
        // Realiza la conexión a la BDs
        private readonly Hotel.App.Persistencia.AppContext _appContext;

        public RepositorioUsuario(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Usuario AddUsuario(Usuario usuario)
        {
                                    // conx BDs     . Tabla  . Operación
            var usuarioAdicionado = this._appContext.Usuarios.Add(usuario);
            this._appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        public void DeleteUsuario(int idUsuario){
            var usuario = this._appContext.Usuarios.FirstOrDefault( u => u.Id == idUsuario);
            if ( usuario != null)
            {
                // borramos el usuario de la tabla Usuarios
                this._appContext.Usuarios.Remove(usuario);

                //guardamos los cambios
                this._appContext.SaveChanges();
            }
        }

        public Usuario getUsuario(int idUsuario)
        {
            var usuario = this._appContext.Usuarios.FirstOrDefault( u => u.Id == idUsuario);
            return usuario;
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return this._appContext.Usuarios;
        }

        public Usuario UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = this._appContext.Usuarios.FirstOrDefault( u => u.Id == usuario.Id);
            if ( usuarioEncontrado != null)
            {
                usuarioEncontrado.Login = usuario.Login;
                usuarioEncontrado.Password = usuario.Password;
                usuarioEncontrado.Email = usuario.Email;

                this._appContext.SaveChanges();   ///commit  ==>>> guardelo en la base datos
            }

            return usuarioEncontrado;
        }

        public void Saludo(){
            Console.WriteLine("hola muindo");
        }
    }
}