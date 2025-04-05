using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DB
    {
        //Atributos 
        protected NpgsqlConnection _conexion;
        public string cadenaConexion;
        //Constructor 
        public DB(string server, string db, string user, string password)
        {
            cadenaConexion = $"Host={server};Username={user};Password={password};Database={db}";
        }
        //Métodos 
        public void Conectar()
        {
            _conexion = new NpgsqlConnection(cadenaConexion);
            _conexion.Open();
        }
    }
}
