using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Intuito
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "127.0.0.1";
        private string dataBase = "prueba_intuito";
        private string user = "root";
        private string pass = "@DoBerman98@@";
        private string port = "8080";
        private string cadena_conexion;

        public Conexion()
        {
            cadena_conexion = "Server=" + server + ";Port=" + port + ";Uid=" + user + ";Password=" + pass + ";Database=" + dataBase + ";";
        }

        public MySqlConnection getConnection()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadena_conexion);
                conexion.Open();
            }
            return conexion;
        }
    }
}
