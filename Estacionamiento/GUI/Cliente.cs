using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.BO;
using Estacionamiento.DAO;
using Estacionamiento.GUI;


namespace Estacionamiento.GUI
{
    public partial class Cliente : Form
    {
        cliente_BO datos = new cliente_BO();
        cliente_DAO ejecutar = new cliente_DAO();
        DataTable dt = new DataTable();
        public Cliente()
        {
            InitializeComponent();
        }
        public void mostrar_div()
        {
            dgv_informaciongral.DataSource = ejecutar.tabla_cliente();
        }
        

        private void Cliente_Load(object sender, EventArgs e)
        {
            txt_codigocliente.Enabled = false;
            mostrar_div();
            Cargar_tarifa();
            dt = ejecutar.tabla_cliente();
        }
        
        private void dgv_informaciongral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_codigocliente.Text = dgv_informaciongral.Rows[fila].Cells["id_cliente"].Value.ToString();
            txt_nombres.Text = dgv_informaciongral.Rows[fila].Cells["nombre"].Value.ToString();
            txt_apellidopat.Text = dgv_informaciongral.Rows[fila].Cells["apellido_paterno"].Value.ToString();
            txt_apellidomat.Text = dgv_informaciongral.Rows[fila].Cells["aellido_materno"].Value.ToString();
            txt_telefono.Text = dgv_informaciongral.Rows[fila].Cells["telefono"].Value.ToString();
            txt_edad.Text = dgv_informaciongral.Rows[fila].Cells["edad"].Value.ToString();
            txt_direccion.Text = dgv_informaciongral.Rows[fila].Cells["direccion"].Value.ToString();
            cmb_tarifa.Text = dgv_informaciongral.Rows[fila].Cells["tiempo_aplicado"].Value.ToString();

        }

        

        private void dgv_informaciongral_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int fila = e.RowIndex;
            txt_codigocliente.Text = dgv_informaciongral.Rows[fila].Cells["id_cliente"].Value.ToString();
            txt_nombres.Text = dgv_informaciongral.Rows[fila].Cells["nombre"].Value.ToString();
            txt_apellidopat.Text = dgv_informaciongral.Rows[fila].Cells["apellido_paterno"].Value.ToString();
            txt_apellidomat.Text = dgv_informaciongral.Rows[fila].Cells["aellido_materno"].Value.ToString();
            txt_telefono.Text = dgv_informaciongral.Rows[fila].Cells["telefono"].Value.ToString();
            txt_edad.Text = dgv_informaciongral.Rows[fila].Cells["edad"].Value.ToString();
            txt_direccion.Text = dgv_informaciongral.Rows[fila].Cells["direccion"].Value.ToString();
            cmb_tarifa.Text = dgv_informaciongral.Rows[fila].Cells["tiempo_aplicado"].Value.ToString();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_apellidopat.Text) || string.IsNullOrEmpty(txt_apellidomat.Text) || string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                datos.Apellido_paterno = txt_apellidopat.Text;
                datos.Apellido_materno = txt_apellidomat.Text;
                datos.Nombre = txt_nombres.Text;
                datos.Edad = int.Parse(txt_edad.Text);
                datos.Telefono = txt_telefono.Text;
                datos.Direccion = txt_direccion.Text;


                if (ejecutar.guardar(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");
                    mostrar_div();
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_apellidopat.Text) || string.IsNullOrEmpty(txt_apellidomat.Text) || string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Id_cliente = int.Parse(txt_codigocliente.Text);
                datos.Apellido_paterno = txt_apellidopat.Text;
                datos.Apellido_materno = txt_apellidomat.Text;
                datos.Nombre = txt_nombres.Text;
                datos.Edad = int.Parse(txt_edad.Text);
                datos.Telefono = txt_telefono.Text;
                datos.Direccion = txt_direccion.Text;


                if (ejecutar.actualizar_cliente(datos) == 0)
                {
                    MessageBox.Show("Error al actualizar datos");
                }
                else
                {
                    MessageBox.Show("Datos Actualizados");
                    mostrar_div();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_apellidopat.Text) || string.IsNullOrEmpty(txt_apellidomat.Text) || string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("Seleccione un registro para poder eliminar");
            }
            else
            {
                datos.Id_cliente = int.Parse(txt_codigocliente.Text);
                if (ejecutar.eliminar_cliente(datos) == 0)
                {
                    MessageBox.Show("error al borrar datos");
                }
                else
                {
                    MessageBox.Show("se han borrado los datos seleccionados");
                    mostrar_div();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_apellidomat.Clear();
            txt_apellidopat.Clear();
            txt_codigocliente.Clear();
            txt_direccion.Clear();
            txt_edad.Clear();
            txt_nombres.Clear();
            txt_telefono.Clear();
        }

        private void cmb_tarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_tarifa = ejecutar.id_tarifa(cmb_tarifa.Text);
            datos.Fk_id_tarifa = int.Parse(fk_id_tarifa);
            //MessageBox.Show(fk_id_tarifa);
        }
        private void Cargar_tarifa()
        {
            cmb_tarifa.Items.Clear();
            ArrayList ListaFinal = ejecutar.listatarifa();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_tarifa.Items.Add(ListaFinal[i].ToString());
            }
        }

        private void btn_agregarvehiculo_Click(object sender, EventArgs e)
        {
            vehiculos objvehi = new vehiculos();
            objvehi.Show();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = string.Concat("[", dt.Columns["telefono"].ColumnName, "]");
            dt.DefaultView.Sort = nombre;
            DataView vista = dt.DefaultView;
            vista.RowFilter = string.Empty;
            if (txt_buscar.Text != string.Empty)
            {
                vista.RowFilter = nombre + "like '%" + txt_buscar.Text + "%'";
                dgv_informaciongral.DataSource = vista;
            }
        }
    }
}
