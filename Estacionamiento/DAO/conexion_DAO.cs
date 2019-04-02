using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Estacionamiento.DAO
{
    class conexion_DAO
    {
        MySqlConnection conex;

        public MySqlConnection Conectar_BD()
        {
            string cadena = "datasource = localhost; username = root; password = 123456; database = proyecto_integrador;Convert Zero Datetime = True";
            conex = new MySqlConnection(cadena);
            return conex;
        }

        public void abrir_BD()
        {
            conex.Open();
        }

        public void cerrar_BD()
        {
            conex.Close();
        }



    }
}
