using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hotel.App.Dominio;
using Hotel.App.Persistencia;

namespace Hotel.App.Frontend.Pages.Usuarios
{
    public class ListadoUsuariosModel : PageModel
    {
        private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new Hotel.App.Persistencia.AppContext());
       
        public IEnumerable<Usuario> Usuarios{get; set;}

        public ListadoUsuariosModel()
        {
        }


        public void OnGet()
        {
            this.Usuarios = _repositorioUsuario.GetAllUsuarios();
        }
    }
}

