using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Interfaz
{
    public interface IProducto
    {
        void InsertarProducto(Producto p);
        void ActualizarProducto(Producto p);
        bool EliminarProducto(Producto p);
    }
}
