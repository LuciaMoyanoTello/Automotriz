using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class Login : ILogin
    {
        public bool Logeado(Cliente c)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@input_usuario", c.Usuario));
            lista.Add(new Parametro("@input_pass", c.Pass));
            DBHelper.ObtenerInstancia().ConsultarSP("[SP_CONSULTAR_LOGIN]", lista);

            if (DBHelper.ObtenerInstancia().Reader.Read())
            {
                DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
                DBHelper.ObtenerInstancia().CerrarConexion();
                return true;
            }
            DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            DBHelper.ObtenerInstancia().CerrarConexion();
            return false;
        }
    }
}
