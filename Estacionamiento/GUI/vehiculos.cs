using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.BO;
using Estacionamiento.DAO;
using System.Runtime.InteropServices;


namespace Estacionamiento.GUI
{
    public partial class vehiculos : Form
    {
        vehiculo_BO datos = new vehiculo_BO();
        vehiculo_DAO ejecutar = new vehiculo_DAO();
        public vehiculos()
        {
            InitializeComponent();
        }

        private void lbl_nombreturno_Click(object sender, EventArgs e)
        {

        }
       
        private void vehiculos_Load(object sender, EventArgs e)
        {
            mostrar_veh();
        }
        public void mostrar_veh()
        {
            dgv_vehiculos.DataSource = ejecutar.tabla_vehiculos();
        }

        private void btn_Agregarvehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_modelo.Text) || string.IsNullOrEmpty(txt_matricula.Text) || string.IsNullOrEmpty(txt_id_cliente.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                datos.Fk_id_cliente = int.Parse(txt_id_cliente.Text);
                datos.Modelo = txt_modelo.Text;
                datos.Matricula = txt_matricula.Text;



                if (ejecutar.guardar(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");
                    mostrar_veh();
                }
            }
        }

        private void btn_editarvehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_modelo.Text) || string.IsNullOrEmpty(txt_matricula.Text) || string.IsNullOrEmpty(txt_id_cliente.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                datos.Fk_id_cliente = int.Parse(txt_id_cliente.Text);
                datos.Modelo = txt_modelo.Text;
                datos.Matricula = txt_matricula.Text;



                if (ejecutar.actualizar_vehiculo(datos) == 0)
                {
                    MessageBox.Show("Error al actualizar datos");
                }
                else
                {
                    MessageBox.Show("Datos Actualizados");
                    mostrar_veh();
                }
            }
        }

        private void btn_eliminarvehiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matricula.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                
                datos.Matricula = txt_matricula.Text;



                if (ejecutar.eliminar_vehiculo(datos) == 0)
                {
                    MessageBox.Show("Error al eliminar datos");
                }
                else
                {
                    MessageBox.Show("Datos eliminados");
                    mostrar_veh();
                }
            }
        }

        private void dgv_vehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_cliente.Text = dgv_vehiculos.Rows[fila].Cells[0].Value.ToString();
            txt_matricula.Text = dgv_vehiculos.Rows[fila].Cells[3].Value.ToString();
            txt_modelo.Text = dgv_vehiculos.Rows[fila].Cells[4].Value.ToString();
        }

        private void dgv_vehiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_cliente.Text = dgv_vehiculos.Rows[fila].Cells[0].Value.ToString();
            txt_matricula.Text = dgv_vehiculos.Rows[fila].Cells[3].Value.ToString();
            txt_modelo.Text = dgv_vehiculos.Rows[fila].Cells[4].Value.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void vehiculos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
