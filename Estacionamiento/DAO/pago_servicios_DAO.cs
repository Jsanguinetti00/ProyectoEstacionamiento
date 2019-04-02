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
    class pago_servicios_DAO
    {
        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int pagar_srvicior(pago_servicio_BO objpagser)
        {
            pago_servicio_BO datos = (pago_servicio_BO)objpagser;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into pago_servicio (folio_servicio, fecha_servicio,total_pago,fk_id_servicio, fk_id_empleado, fk_id_corte) values('" + datos.Folio_servicio + "', '" + datos.Fecha_servicio + "', '" + datos.Total_pago + "', '" + datos.Fk_id_servicio + "', '" + datos.Fk_id_empleado + "',   '" + datos.Fk_id_corte + "')";
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
        public string id_servicio(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_servicio from servicio where tipo_servicio='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_servicio", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_servicio"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }
        public ArrayList listapagser()
        {

            SQL = "Select tipo_servicio from servicio";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listserv = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listserv.Add(lectura["tipo_servicio"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listserv;

        }
        public DataTable tabla_pagserv()
        {

            SQL = "select folio_servicio, fecha_servicio, total_pago, id_servicio, id_empleado, id_corte from pago_servicio inner join servicio  on fk_id_servicio = servicio.id_servicio inner join empleado on fk_id_empleado = empleado.id_empleado inner join corte on fk_id_corte = corte.id_corte; ";
            MySqlDataAdapter t_pagser = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_pagsertabla = new DataTable();
            t_pagser.Fill(virtual_pagsertabla);
            return virtual_pagsertabla;




        }

    }





}
