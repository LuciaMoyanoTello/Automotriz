using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos.Implementacion
{
    public class Login : ILogin
    {
        public DataTable Logeado(Cliente c)
        {
            //DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            //DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@input_usuario", c.Usuario);
            //DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@input_pass", c.Pass);
            //DBHelper.ObtenerInstancia().LeerDB("[SP_CONSULTAR_LOGIN]");

            //if (DBHelper.ObtenerInstancia().Reader.Read())
            //{
            //    DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            //    DBHelper.ObtenerInstancia().CerrarConexion();
            //    return true;
            //}
            //DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            //DBHelper.ObtenerInstancia().CerrarConexion();
            //return false;

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Add(new Parametro("@input_usuario", c.Usuario));
            lParametros.Add(new Parametro("@input_pass", c.Pass));
            DataTable tClientes = DBHelper.ObtenerInstancia().ConsultarSP("[SP_CONSULTAR_LOGIN]", lParametros);

            return tClientes;
        }
    }
}
