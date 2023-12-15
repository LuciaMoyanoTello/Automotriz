using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Fachada.Interfaz
{
    public interface IAplicacion
    {
        List<Producto> GetProductos();
        List<Cliente> GetClientes();
        bool Cliente(Cliente cliente);
        bool GuadarPresupuesto(Presupuesto presupuesto);
        DataTable Logeado(Cliente c);
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        bool EliminarProducto(Producto producto);
        bool EliminarPresupuesto(Presupuesto presupuesto);
    }
}
