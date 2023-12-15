using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao presupuestoDao;
        private ILogin login;
        private IProducto productoDao;
        public Aplicacion()
        {
            presupuestoDao = new PresupuestoDao();
            login = new Login();
            productoDao = new ProductoDao();
        }
        public List<Producto> GetProductos()
        {
            return presupuestoDao.ObtenerProductos();
        }

        public bool GuadarPresupuesto(Presupuesto presupuesto)
        {
            return presupuestoDao.CrearPresupuesto(presupuesto);
        }

        bool IAplicacion.Cliente(Cliente cliente)
        {
            return presupuestoDao.Cliente(cliente);
        }

        List<Cliente> IAplicacion.GetClientes()
        {
            return presupuestoDao.ObtenerCliente();
        }

        void IAplicacion.InsertarProducto(Producto producto)
        {
            productoDao.InsertarProducto(producto);
        }

        void IAplicacion.ActualizarProducto(Producto producto)
        {
            productoDao.ActualizarProducto(producto);
        }

        bool IAplicacion.EliminarProducto(Producto producto)
        {
            return productoDao.EliminarProducto(producto);
        }

        DataTable IAplicacion.Logeado(Cliente c)
        {
            return login.Logeado(c);
        }

        bool IAplicacion.EliminarPresupuesto(Presupuesto presupuesto)
        {
            return presupuestoDao.EliminarPresupuesto(presupuesto);
        }
    }
}
