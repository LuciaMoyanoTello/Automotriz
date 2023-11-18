using AutomotrizApp.Datos.Interfaz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class ProductoDao : IProducto
    {
        public bool ActualizarProducto(Entidades.Producto p)
        {
            throw new NotImplementedException();
        }

        public bool InsertarProducto(Entidades.Producto p)
        {
            //Va esto para un idNuevoProducto???
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultarSP("[SP_PROXIMO_ID_PRODUCTOS]");
            int idNuevoProducto = Convert.ToInt32(tabla.Rows[0][0]);

            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@input_id_producto", Convert.ToString(idNuevoProducto)));
            lista.Add(new Parametro("@input_nombre", p.Nombre));
            lista.Add(new Parametro("@input_precio", p.Precio));
            lista.Add(new Parametro("@input_id_tipo", p.Tipo));

            DBHelper.ObtenerInstancia().ConsultarSP("SP_INSERTAR_PRODUCTOS", lista);
            return true;
        }
    }
}
