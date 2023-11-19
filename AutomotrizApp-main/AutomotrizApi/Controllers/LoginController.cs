using AutomotrizApp.Entidades;
using AutomotrizApp.Fachada.Implementacion;
using AutomotrizApp.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IAplicacion app;

        public LoginController()
        {
            app = new Aplicacion();
        }

        [HttpPost("PostLogin")]
        public IActionResult PostLogin(Cliente c)
        {
            try
            {
                return Ok(app.Logeado(c));

            }
            catch (Exception)
            {
                return BadRequest("Error del Servidor");
            }

        }
    }
}
