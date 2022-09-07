using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hotel.App.Dominio;
using Hotel.App.Persistencia;

namespace Hotel.App.Frontend.Pages
{
    public class CrearUsuarioModel : PageModel
    {
        private static IRepositorioUsuario _repositorioUsuario = new RepositorioUsuario(new Hotel.App.Persistencia.AppContext());

        [BindProperty]
        public Usuario Usuario {get; set;}

        public CrearUsuarioModel()
        {}
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost(){
            try
            {
                Usuario.FechaAlta = System.DateTime.Now;
                Usuario.UltimoAcceso = System.DateTime.Now;

                //Adicionarlo a la BDS
                Usuario usuarioAdicionado = _repositorioUsuario.AddUsuario(Usuario);
                return RedirectToPage("./ListadoUsuarios");
            }
            catch (System.Exception e)
            {
                ViewData["Error"] = e.Message;
                return Page(); 
            }
        }
    }
}
