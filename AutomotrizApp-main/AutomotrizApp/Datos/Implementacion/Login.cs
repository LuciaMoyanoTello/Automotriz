using AutomotrizApp.Datos.Interfaz;
using AutomotrizApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.Datos.Implementacion
{
    public class Login : ILogin
    {
        public bool Logeado(Cliente c)
        {
            DBHelper.ObtenerInstancia().Comando.Parameters.Clear();
            DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@input_usuario", c.Usuario);
            DBHelper.ObtenerInstancia().Comando.Parameters.AddWithValue("@input_pass", c.Pass);
            DBHelper.ObtenerInstancia().LeerDB("[SP_CONSULTAR_LOGIN]");

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

        List<Cliente> ILogin.ObtenerLogin()
        {
            List<Cliente> lClientes = new List<Cliente>();
            DataTable tClientes = DBHelper.ObtenerInstancia().ConsultarSP("[SP_CONSULTAR_LOGIN]");

            foreach (DataRow row in tClientes.Rows)
            {
                Cliente c = new Cliente
                {
                    NombreCompleto = Convert.ToString(row["Nombre Completo"]),
                    Dni = Convert.ToString(row["DNI"]),
                    Telefono = Convert.ToString(row["Telefono"])
                };

                lClientes.Add(c);
            }
            return lClientes;
        }
    }
}
