using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Estacionamiento.BO;
using System.Data;

namespace Estacionamiento.DAO
{
    class verificacion_DAO
    {
        verificacion_BO datos = new verificacion_BO();
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;

        public bool autentificacion(verificacion_BO objveri)
        {
            verificacion_BO datos = (verificacion_BO)objveri;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "Select *from usuario where n_usuario='"+datos.No_usuario+"'  and contrasena='"+datos.Contraseña+"'    ";
            cmd.CommandText = SQL;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();



            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }


            
        }


    }
}
