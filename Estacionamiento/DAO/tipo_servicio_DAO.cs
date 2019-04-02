using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.BO;
using Estacionamiento.DAO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Estacionamiento.DAO
{
    class tipo_servicio_DAO
    {
        tipo_servicios_BO datos = new tipo_servicios_BO();
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(tipo_servicios_BO objetipser)
        {
            tipo_servicios_BO datos = (tipo_servicios_BO)objetipser;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into servicio (tipo_servicio) values('" + datos.Tipo_servicio + "')";
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

        public int actualizar_tipo_servicios(tipo_servicios_BO objetipser)
        {
            tipo_servicios_BO datos = (tipo_servicios_BO)objetipser;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update servicio set tipo_servicio=('" + datos.Tipo_servicio + "') where id_servicio = '" + datos.Id_servicio + "'";
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

        public int eliminar_servicio(tipo_servicios_BO objtipser)
        {
            tipo_servicios_BO datos = (tipo_servicios_BO)objtipser;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from servicio where id_servicio='" + datos.Id_servicio + "'";
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

        public DataTable tabla_tipo_servicios()
        {

            SQL = "select * from servicio";
            MySqlDataAdapter t_emple = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_empletabla = new DataTable();
            t_emple.Fill(virtual_empletabla);
            return virtual_empletabla;



        }
    }
}
