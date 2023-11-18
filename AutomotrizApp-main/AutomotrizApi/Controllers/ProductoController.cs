using AutomotrizApp.Entidades;
using AutomotrizApp.Fachada.Implementacion;
using AutomotrizApp.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private IAplicacion app;
        public ProductoController()
        {
            app = new Aplicacion();
        }
        [HttpPost("PostProducto")]
        public IActionResult PostProducto(Producto p)
        {
            try
            {
                return Ok(app.InsertarProducto(p));
            }
            catch
            {
                return BadRequest("Error del servidor");
            }
        }
    }
}
