using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
{
    public class ProductoDao : IProducto
    {
        public void InsertarProducto(Producto p)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@input_id_producto", p.Id));
            lista.Add(new Parametro("@input_nombre", p.Nombre));
            lista.Add(new Parametro("@input_precio", p.Precio));
            lista.Add(new Parametro("@input_id_tipo", p.Tipo));

            DBHelper.ObtenerInstancia().ConsultarSP("SP_INSERTAR_PRODUCTOS", lista);
        }


        public void ActualizarProducto(Producto p)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@input_id_producto", p.Id));
            lista.Add(new Parametro("@input_nombre", p.Nombre));
            lista.Add(new Parametro("@input_precio", p.Precio));
            lista.Add(new Parametro("@input_id_tipo", p.Tipo));

            DBHelper.ObtenerInstancia().ConsultarSP("SP_ACTUALIZAR_PRODUCTOS", lista);
        }


        bool IProducto.EliminarProducto(Producto p)
        {
            List<Parametro> parametro = new List<Parametro>() { new Parametro("@input_id_producto", p.Id) };

            DBHelper.ObtenerInstancia().ConsultarSP("SP_ELIMINAR_PRODUCTOS", parametro); //Elimina de la base de datos
            return true;
        }
    }
}
