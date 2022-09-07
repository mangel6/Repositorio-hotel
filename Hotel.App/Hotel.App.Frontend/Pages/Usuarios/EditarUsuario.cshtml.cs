using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hotel.App.Persistencia;
using Hotel.App.Dominio;

namespace Hotel.App.Frontend.Pages
{

    public class EditarUsuarioModel : PageModel
    {
        private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new Hotel.App.Persistencia.AppContext());

        [BindProperty]
        public Usuario Usuario {get; set;}

        public EditarUsuarioModel()
        {}

        public ActionResult OnGet(int id)
        {
            Usuario = _repositorioUsuario.getUsuario(id);
            return Page();
        }

        public ActionResult OnPost()
        {
            try
            {
                Usuario usuarioActualizado = _repositorioUsuario.UpdateUsuario(this.Usuario);
                return RedirectToPage("ListadoUsuarios");    
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                return Page();
            }
            
        }
    }
}
