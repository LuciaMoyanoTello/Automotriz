using AutomotrizApp.Datos.Implementacion;
using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using AutomotrizApp.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao dao;
        private ILogin login;
        private IProducto prod;
        public Aplicacion()
        {
            dao = new PresupuestoDao();
            login = new Login();
            prod = new ProductoDao();
        }
        public List<Producto> GetProductos()
        {
            return dao.ObtenerProductos();
        }

        public bool GuadarPresupuesto(Presupuesto presupuesto)
        {
            return dao.CrearPresupuesto(presupuesto);
        }

        bool IAplicacion.Cliente(Cliente cliente)
        {
            return dao.Cliente(cliente);
        }

        List<Cliente> IAplicacion.GetClientes()
        {
            return dao.ObtenerCliente();
        }

        bool IAplicacion.InsertarProducto(Producto producto)
        {
            return prod.InsertarProducto(producto);
        }

        bool IAplicacion.Logeado(Cliente c)
        {
            return login.Logeado(c);
        }
    }
}
