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
    class turnos_DAO
    {
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(turno_BO objturnos)
        {
            turno_BO datos = (turno_BO)objturnos;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into turno (hora_inicial, hora_final, tipo_turno) values('" + datos.Hora_inicial + "', '" + datos.Hora_final + "', '" + datos.Nombre_turno + "')";
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

        public int actualizar_turno(turno_BO objturno)
        {
            turno_BO datos = (turno_BO)objturno;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update turno set hora_inicial='" + datos.Hora_inicial + "', hora_final='" + datos.Hora_final + "', tipo_turno='" + datos.Nombre_turno + "' where  id_turno ='" + datos.Id_turno + "'";
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

        public int eliminar_turno(turno_BO objturno)
        {
            turno_BO datos = (turno_BO)objturno;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from turno where id_turno='" + datos.Id_turno + "'";
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



        public DataTable tabla_turnos()
        {

            SQL = "select * from turno";
            MySqlDataAdapter t_turn = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_turntabla = new DataTable();
            t_turn.Fill(virtual_turntabla);
            return virtual_turntabla;




        }

    }
}
