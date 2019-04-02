using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Estacionamiento.BO;

namespace Estacionamiento.DAO
{
    class tickets_DAO
    {
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(tickets_BO objticket)
        {
            tickets_BO datos = (tickets_BO)objticket;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into ticket(fecha_hora_entrada, matricula, fk_id_cajon, fk_id_empleado, fk_id_tarifa) values ( '"+datos.Fecha_hora_entrada.ToString("yyyy-MM-dd HH:mm:ss") + "', '"+datos.Matricula+"', '"+datos.Fk_id_cajon+"', '"+datos.Fk_id_empleado+"', '"+datos.Fk_id_tarifa+"')";
            cmd.CommandText = SQL;
            int transac = cmd.ExecuteNonQuery();
            obj_conexion.cerrar_BD();
            if(transac <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int actualizar_ticket(tickets_BO objticket)
        {
            tickets_BO datos = (tickets_BO)objticket;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update cliente set fecha_hora_salida='" + datos.Fecha_hora_salida + "',  total_pagar='" + datos.Total_pagar + "''  where id_cliente = '" + datos.Folio_ticket + "'";
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



        public DataTable tabla_ticket()
        {
            SQL = "select * from ticket";
            MySqlDataAdapter t_ticket = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_ticketabla = new DataTable();
            t_ticket.Fill(virtual_ticketabla);
            return virtual_ticketabla;

        }

        public string id_empleado(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_empleado from empleado where nombre='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_empleado", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_empleado"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }

        //CHECA ESTE
        public string id_cajon(string nombre_combo)
        {
            string id = "";
            SQL = "Select id_cajon from cajones where estatus='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_cajon", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_cajon"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }




        public string id_turno(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_turno from turno where tipo_turno='" + nombre_combo + "'";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue("id_turno", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_turno"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }

        public string id_tarifa(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_tarifa from tarifa where tiempo_aplicado ='" + nombre_combo + "'";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue("id_tarifa", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_tarifa"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }

        public ArrayList listaempleados()
        {

            SQL = "Select nombre from empleado";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listempe = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listempe.Add(lectura["nombre"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listempe;

        }

        public ArrayList listacajones()
        {

            SQL = "Select id_cajon from cajones where estatus = 'Disponible'";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listcajon = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listcajon.Add(lectura["id_cajon"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listcajon;

        }





        public ArrayList listatarifa()
        {

            SQL = "Select tiempo_aplicado from tarifa";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listtarif = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listtarif.Add(lectura["tiempo_aplicado"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listtarif;

        }

    }
}
