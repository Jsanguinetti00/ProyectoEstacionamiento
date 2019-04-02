using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Estacionamiento.BO;
using System.Data;

namespace Estacionamiento.DAO
{
    class empleado_DAO
    {
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(Empleado_BO objempleado)
        {
            Empleado_BO datos = (Empleado_BO)objempleado;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into empleado (curp, nombre, apellido_paterno, apellido_materno, edad, direccion_empleado,telefono_empleado, fk_id_empresa, fk_id_turno) values('" + datos.Curp + "', '" + datos.Nombres + "', '" + datos.Apellido_paterno + "', '" + datos.Apellido_materno + "', '" + datos.Edad + "',   '" + datos.Direccion + "', '" + datos.Telefono + "', '" + datos.Fk_id_empresa + "', '" + datos.Fk_id_turno + "')";
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

        public string id_empleado(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_empresa from empresa where nombre_empresa='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_empresa", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_empresa"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }
        public string id_turno(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_turno from turno where tipo_turno='"+ nombre_combo +"'";
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

        public int actualizar_empleado(Empleado_BO objempleado)
        {
            Empleado_BO datos = (Empleado_BO)objempleado;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update empleado set curp='"+datos.Curp+"', nombre='" + datos.Nombres + "',  apellido_paterno='" + datos.Apellido_paterno + "', apellido_materno='" + datos.Apellido_materno + "',   edad='" + datos.Edad + "' ,  direccion_empleado='" + datos.Direccion + "', telefono_empleado='" + datos.Telefono + "', fk_id_empresa= '"+datos.Fk_id_empresa+"', fk_id_turno='"+datos.Fk_id_turno+"'  where id_empleado = '" + datos.Id_empleado + "'";
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

        public int eliminar_empleado(Empleado_BO objempleado)
        {
            Empleado_BO datos = (Empleado_BO)objempleado;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from empleado where id_empleado='" + datos.Id_empleado + "'";
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

        public DataTable tabla_empleado()
        {

            SQL = "select id_empleado, curp, nombre, apellido_paterno, apellido_materno,edad, direccion, telefono_empleado, nombre_empresa, tipo_turno from empleado  inner join empresa  on empleado.fk_id_empresa=empresa.id_empresa inner join turno on empleado.fk_id_turno=id_turno  ";
            MySqlDataAdapter t_emple = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_empletabla = new DataTable();
            t_emple.Fill(virtual_empletabla);
            return virtual_empletabla;




        }
        public DataTable tabla_usuario()
        {

            SQL = "select id_empleado nombre, apellido_paterno, apellido_materno tipo_turno, n_usuario, contrasena from empleado  inner join empresa  on empleado.fk_id_empresa=empresa.id_empresa  inner join usuario on usuario.fk_id_empleado=empleado.id_empleado ";
            MySqlDataAdapter t_emple = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_empletabla = new DataTable();
            t_emple.Fill(virtual_empletabla);
            return virtual_empletabla;




        }
        public ArrayList listaturno()
        {
            
            SQL = "Select tipo_turno from turno";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listturn = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listturn.Add(lectura["tipo_turno"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listturn;

        }
        public ArrayList listaempresa()
        {

            SQL = "Select nombre_empresa from empresa";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listempre = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listempre.Add(lectura["nombre_empresa"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listempre;

        }
        

    }
}
