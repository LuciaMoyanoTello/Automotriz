using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Entidades
{
    public class Cliente
    {
        //Atributos
        int id;
        string nombreCompleto;
        string dni;
        string telefono;
        string usuario;
        string pass;


        //Propiedades
        public int Id                   { get { return id; }                set { id = value; } }
        public string NombreCompleto    { get { return nombreCompleto; }    set { nombreCompleto = value; } }
        public string Dni               { get { return dni; }               set { dni = value; } }
        public string Telefono          { get { return telefono; }          set { telefono = value; } }
        public string Usuario           { get { return usuario; }           set { usuario = value; } }
        public string Pass              { get { return pass; }              set { pass = value; } }

        //Constructor
        public Cliente(int Id = -1, string NombreCompleto = "(Sin especificar)", string Dni = "(Sin especificar)", string Telefono = "(Sin especificar)", string Usuario = "user", string Pass = "pass")
        {
            this.Id = Id;
            this.NombreCompleto = NombreCompleto;
            this.Dni = Dni;
            this.Telefono = Telefono;
            this.Usuario = Usuario;
            this.Pass = Pass;
        }


        //Metodos

    }
}
