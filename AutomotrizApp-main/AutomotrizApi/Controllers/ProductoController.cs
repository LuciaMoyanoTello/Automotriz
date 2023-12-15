using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Implementacion;
using AutomotrizBack.Fachada.Interfaz;
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
        [HttpPost("InsertProducto")]
        public IActionResult InsertProducto(Producto p)
        {
            try
            {
                app.InsertarProducto(p);
                return Ok();
            }
            catch
            {
                return BadRequest("Error del servidor");
            }
        }

        [HttpPost("UpdateProducto")]
        public IActionResult UpdateProducto(Producto p)
        {
            try
            {
                app.ActualizarProducto(p);
                return Ok();
            }
            catch
            {
                return BadRequest("Error del servidor");
            }
        }


        [HttpPost("DeleteProducto")]
        public IActionResult DeleteProducto(Producto p)
        {
            try
            {
                app.EliminarProducto(p);
                return Ok();
            }
            catch
            {
                return BadRequest("Error del servidor");
            }
        }
    }
}
