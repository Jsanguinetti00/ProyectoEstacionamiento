using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.BO;
using Estacionamiento.DAO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace Estacionamiento.DAO
{
    class cajon_DAO
    {
        conexion_DAO obj_conexion = new conexion_DAO();
        cajon_BO datos = new cajon_BO();

        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(cajon_BO objcajo)
        {
            cajon_BO datos = (cajon_BO)objcajo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            for(int i=1;i<datos.Gencajon;i++)
            {
                SQL = "insert into cajones (estatus, fk_id_estacionamiento, fk_id_tipocajon) values('" + datos.Estatus + "', '" + datos.Fk_id_estacionamiento + "', '" + datos.Fk_id_tipocajon + "')";
                cmd.CommandText = SQL;
                int transac = cmd.ExecuteNonQuery();
                if (transac<=0)
                {
                    return 0;
                }
            }
            
            
            obj_conexion.cerrar_BD();
            
            
                return 1;
            
        }

        public int actualizar_cajon(cajon_BO objcajo)
        {
            cajon_BO datos = (cajon_BO)objcajo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update cajones set estatus='" + datos.Estatus + "', fk_id_estacionamiento='" + datos.Fk_id_estacionamiento + "',  fk_id_tipocajon='" + datos.Fk_id_tipocajon + "' where id_cajon = '" + datos.Id_cajon + "'";
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

        public int eliminar_cajon(cajon_BO objcajo)
        {
            cajon_BO datos = (cajon_BO)objcajo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from cajones where id_cajon='" + datos.Id_cajon + "'";
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

        public string id_tipocajon(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_tipocajon from tipo_cajon where tipo_de_cajon='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_tipocajon", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_tipocajon"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }

        public string id_estacionamiento(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_estacionamiento from estacionamiento where nombre='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_estacionamiento", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_estacionamiento"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }

        public ArrayList listaestacionamiento()
        {

            SQL = "Select nombre from estacionamiento";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listestacion = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listestacion.Add(lectura["nombre"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listestacion;

        }

        public ArrayList listacajon()
        {

            SQL = "Select tipo_de_cajon from tipo_cajon";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listcajon = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listcajon.Add(lectura["tipo_de_cajon"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listcajon;

        }

        public DataTable tabla_cajon()
        {

            SQL = "select id_cajon, estatus, tipo_de_cajon, nombre   from cajones inner join tipo_cajon on cajones.fk_id_tipocajon=tipo_cajon.id_tipocajon inner join estacionamiento on cajones.fk_id_estacionamiento=estacionamiento.id_estacionamiento";
            MySqlDataAdapter t_vehi = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_vehitabla = new DataTable();
            t_vehi.Fill(virtual_vehitabla);
            return virtual_vehitabla;




        }

        public int disponible()
        {

            
            SQL = "Select count(*) from cajones where estatus='Disponible'";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            
            cmd.ExecuteScalar();

            int cat = Convert.ToInt32(cmd.ExecuteScalar());

            obj_conexion.cerrar_BD();
            
                return cat;
            

        }
        public int ocupado()
        {


            SQL = "Select count(*) from cajones where estatus='Ocupado'";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();

            cmd.ExecuteScalar();

            int cat = Convert.ToInt32(cmd.ExecuteScalar());

            obj_conexion.cerrar_BD();

            return cat;


        }

        public int cajon_disponible(cajon_BO objcajo)
        {
            cajon_BO datos = (cajon_BO)objcajo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update cajones set estatus='Disponible' where id_cajon = '" + datos.Id_cajon + "'";
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

        public int cajon_ocupado(cajon_BO objcajo)
        {
            cajon_BO datos = (cajon_BO)objcajo;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update cajones set estatus='Ocupado' where id_cajon = '" + datos.Id_cajon + "'";
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
    }
}
