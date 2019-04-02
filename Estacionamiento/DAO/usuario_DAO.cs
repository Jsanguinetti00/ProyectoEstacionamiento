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
    class usuario_DAO
    {
        usuario_BO datos = new usuario_BO();
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(usuario_BO objusuario)
        {
            usuario_BO datos = (usuario_BO)objusuario;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into usuario (fk_id_empleado, n_usuario, contrasena, fk_id_tipo_cuenta) values('" + datos.Fk_id_empleado + "', '" + datos.Usuario + "', '" + datos.Contraseña + "','" + datos.Fk_id_tipo_cuenta + "')";
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

        public int actualizar_usuarios(usuario_BO objusuario)
        {
            usuario_BO datos = (usuario_BO)objusuario;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update usuario set n_usuario='" + datos.Usuario + "', contrasena='" + datos.Contraseña + "'where  fk_id_empleado ='" + datos.Fk_id_empleado + "'";
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

        public int eliminar_usuario(usuario_BO objusuario)
        {
            usuario_BO datos = (usuario_BO)objusuario;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from usuario where fk_id_empleado='" + datos.Fk_id_empleado + "'";
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
        public DataTable tabla_usuario()
        {

            SQL = "select id_empleado, nombre, apellido_paterno, apellido_materno, n_usuario, contrasena, tipo_de_cuenta from usuario  inner join tipo_cuenta  on usuario.fk_id_tipo_cuenta=tipo_cuenta.id_tipo_cuenta  inner join empleado on usuario.fk_id_empleado=empleado.id_empleado ";
            MySqlDataAdapter t_emple = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_empletabla = new DataTable();
            t_emple.Fill(virtual_empletabla);
            return virtual_empletabla;


        }
        public ArrayList listatipo()
        {

            SQL = "Select tipo_de_cuenta from tipo_cuenta";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listtipo = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listtipo.Add(lectura["tipo_de_cuenta"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listtipo;

        }

        public string id_tipo_cuenta(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_tipo_cuenta from tipo_cuenta where tipo_de_cuenta='" + nombre_combo + "'";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue("id_tipo_cuenta", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_tipo_cuenta"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }


    }
}
