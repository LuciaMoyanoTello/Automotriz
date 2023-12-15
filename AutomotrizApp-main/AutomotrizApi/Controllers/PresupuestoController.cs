using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Implementacion;
using AutomotrizBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace AutomotrizApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestoController : ControllerBase
    {
        private IAplicacion app;
        public PresupuestoController()
        {
            app = new Aplicacion();
        }


        [HttpGet("ComboProductos")]
        public IActionResult GetProductos()
        {
            List<Producto> lst;
            try
            {
                lst = app.GetProductos();
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente luego!!");
            }
        }

        [HttpPost("InsertPresupuesto")]
        public IActionResult PostPresupuesto(Presupuesto oPre)
        {
            try
            {
                if (oPre == null)
                {
                    return BadRequest("Presupuesto incorrecto!!");
                }
                return Ok(app.GuadarPresupuesto(oPre));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente luego!!");
            }
        }
        [HttpPost("DeletePresupuesto")]
        public IActionResult DeletePresupuesto(Presupuesto p)
        {
            try
            {
                app.EliminarPresupuesto(p);
                return Ok();
            }
            catch
            {
                return BadRequest("Error del servidor");
            }
        }
    }
}
