using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.BO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Estacionamiento.DAO
{
    class vehiculo_DAO
    {
        vehiculo_BO datos = new vehiculo_BO();
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(vehiculo_BO objvehiculo)
        {
            vehiculo_BO datos = (vehiculo_BO)objvehiculo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into vehiculos (matricula, modelo, fk_id_cliente) values('" + datos.Matricula + "', '" + datos.Modelo + "', '" + datos.Fk_id_cliente + "')";
            cmd.CommandText = SQL;
            int transac = cmd.ExecuteNonQuery();
            obj_conexion.cerrar_BD();
            if (transac <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int actualizar_vehiculo(vehiculo_BO objvehiculo)
        {
            vehiculo_BO datos = (vehiculo_BO)objvehiculo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update vehiculos set matricula='" + datos.Matricula + "', modelo='" + datos.Modelo + "',  fk_id_cliente='" + datos.Fk_id_cliente + "' where matricula = '" + datos.Matricula + "'";
            cmd.CommandText = SQL;
            int transac = cmd.ExecuteNonQuery();
            obj_conexion.cerrar_BD();
            if (transac <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int eliminar_vehiculo(vehiculo_BO objvehiculo)
        {
            vehiculo_BO datos = (vehiculo_BO)objvehiculo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from vehiculos where matricula='" + datos.Matricula + "'";
            cmd.CommandText = SQL;
            int transac = cmd.ExecuteNonQuery();
            obj_conexion.cerrar_BD();
            if (transac <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public DataTable tabla_vehiculos()
        {

            SQL = "select id_cliente, apellido_paterno, aellido_materno, matricula, modelo from vehiculos inner join cliente on vehiculos.fk_id_cliente=cliente.id_cliente";
            MySqlDataAdapter t_vehi = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_vehitabla = new DataTable();
            t_vehi.Fill(virtual_vehitabla);
            return virtual_vehitabla;




        }






    }
}
