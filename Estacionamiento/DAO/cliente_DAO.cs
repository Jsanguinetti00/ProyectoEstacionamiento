using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Estacionamiento.BO;
using System.Data;
using Estacionamiento.GUI;

namespace Estacionamiento.DAO
{
    class cliente_DAO
    {

        conexion_DAO obj_conexion = new conexion_DAO();
        MySqlCommand cmd = new MySqlCommand();
        string SQL;
        public int guardar(cliente_BO objcliente)
        {
            cliente_BO datos = (cliente_BO)objcliente;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "insert into cliente (nombre, apellido_paterno, aellido_materno, edad, telefono, direccion, fk_id_tarifa) values('" + datos.Nombre + "', '" + datos.Apellido_paterno + "', '" + datos.Apellido_materno + "', '" + datos.Edad + "', '" + datos.Telefono + "',  '" + datos.Direccion + "', '"+datos.Fk_id_tarifa+"')";
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

        


        //REVISAR CON MAS DETENIMIENTO
        public string id_tarifa(string nombre_combo)
        {

            string id = "";
            SQL = "Select id_tarifa from tarifa where tiempo_aplicado='" + nombre_combo + "  '";
            MySqlCommand cmd = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            cmd.Parameters.AddWithValue(@"id_tarifa", id);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["id_tarifa"].ToString());

            }

            obj_conexion.cerrar_BD();
            return id;

        }
        //MODIFICAR
        public ArrayList listatarifa()
        {

            SQL = "Select tiempo_aplicado from tarifa";
            MySqlCommand BD = new MySqlCommand(SQL, obj_conexion.Conectar_BD());
            obj_conexion.abrir_BD();
            MySqlDataReader lectura;
            ArrayList listtarf = new ArrayList();
            lectura = BD.ExecuteReader();
            while (lectura.Read())
            {
                listtarf.Add(lectura["tiempo_aplicado"].ToString());
            }
            obj_conexion.cerrar_BD();
            return listtarf;

        }

        public int actualizar_cliente(cliente_BO objcliente)
        {
            cliente_BO datos = (cliente_BO)objcliente;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "update cliente set nombre='" + datos.Nombre + "',  apellido_paterno='" + datos.Apellido_paterno + "', aellido_materno='" + datos.Apellido_materno + "',  telefono='" + datos.Telefono + "',  edad='" + datos.Edad + "',  direccion='" + datos.Direccion + "'  where id_cliente = '" + datos.Id_cliente + "'";
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

        public int eliminar_cliente(cliente_BO objcliente)
        {
            cliente_BO datos = (cliente_BO)objcliente;
            cmd.Connection = obj_conexion.Conectar_BD();
            obj_conexion.abrir_BD();
            SQL = "delete from cliente where id_cliente='" + datos.Id_cliente + "'";
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


        public DataTable tabla_cliente()
        {

            SQL = "select id_cliente, nombre, apellido_paterno, aellido_materno,edad, telefono, direccion, costo_tarifa, tiempo_aplicado from cliente  inner join tarifa  on cliente.fk_id_tarifa=tarifa.id_tarifa";
            MySqlDataAdapter t_clien = new MySqlDataAdapter(SQL, obj_conexion.Conectar_BD());
            DataTable virtual_clientabla = new DataTable();
            t_clien.Fill(virtual_clientabla);
            return virtual_clientabla;




        }








    }
}
