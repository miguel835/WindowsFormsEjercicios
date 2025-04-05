using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class LibroDB: DB
    {
        NpgsqlCommand comando;
        //Constructor
        public LibroDB(string server, string db, string user, string password):
            base (server, db, user, password)
        {}
        //Métodos
        public void CrearTabla()
        {
            string query = "CREATE TABLE IF NOT EXISTS Biblioteca (" +
               "\"Nombre Libro\" CHARACTER VARYING, " +
               "\"Autor\" CHARACTER VARYING, " +
               "\"Editorial\" CHARACTER VARYING, " +
               "\"Año de publicación\" CHARACTER VARYING);";
            Conectar();
            comando = new NpgsqlCommand(query, _conexion);
            comando.ExecuteNonQuery();
        }
        public void AgregarPersonas(List<string> data)
        {
            Conectar();
            string query = "INSERT INTO public.\"biblioteca\"(\"Nombre Libro\", \"Autor\", " + 
                "\"Editorial\", \"Año de publicación\")" + 
                $"VALUES ('{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}');";
            comando = new NpgsqlCommand(query, _conexion);
            comando.ExecuteNonQuery();
        }
        public void ConsultarPersonas(DataGridView dataGridView1) 
        {
            Conectar();
            string query = "SELECT * FROM public.\"biblioteca\";";
            comando = new NpgsqlCommand(query, _conexion);
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(comando);
            DataTable dataTable = new DataTable();
            npgsqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}