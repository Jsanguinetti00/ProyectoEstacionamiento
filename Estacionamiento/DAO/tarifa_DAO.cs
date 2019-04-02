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
    class tarifa_DAO
    {

        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(tarifa_BO objempleado)
        {
            tarifa_BO datos = (tarifa_BO)objempleado;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into tarifa (costo_tarifa, tiempo_aplicado) values('" + datos.Costo_tarifa + "', '" + datos.Tiempo_aplicado + "')";
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

        public int actualizar_tarifa(tarifa_BO objcliente)
        {
            tarifa_BO datos = (tarifa_BO)objcliente;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update tarifa set costo_tarifa='" + datos.Costo_tarifa + "',  tiempo_aplicado'" + datos.Tiempo_aplicado + "'  where id_cliente = '" + datos.Id_tarifa + "'";
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

        public int eliminar_tarifa(tarifa_BO objcliente)
        {
            tarifa_BO datos = (tarifa_BO)objcliente;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from tarifa where id_tarifa='" + datos.Id_tarifa + "'";
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
        public DataTable tabla_tarifa()
        {

            SQL = "select *from tarifa ";
            MySqlDataAdapter t_emple = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_tariftabla = new DataTable();
            t_emple.Fill(virtual_tariftabla);
            return virtual_tariftabla;




        }








    }
}
