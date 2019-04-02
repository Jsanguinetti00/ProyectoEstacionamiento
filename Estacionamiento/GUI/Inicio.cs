using System;
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

namespace Estacionamiento.GUI
{
    public partial class Inicio : Form
    {
        cajon_BO datos = new cajon_BO();
        cajon_DAO ejecutar = new cajon_DAO();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            tmr_fecha.Enabled = true;
            mostrar_estado();
            disponibles();
            ocupado();
        }
        public void mostrar_estado()
        {
            dgv_estado.DataSource = ejecutar.tabla_cajon();
        }
        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void tmr_fecha_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
        }
        private void ocupado()
        {
            lbl_numocup.Text = ejecutar.ocupado().ToString();
        }
        private void disponibles()
        {
            lbl_numdisp.Text = ejecutar.disponible().ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_cajon.Text))
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {
                datos.Id_cajon = int.Parse(txt_id_cajon.Text);




                if (ejecutar.cajon_ocupado(datos) == 0)
                {
                    MessageBox.Show("Error al actualizar estatus");
                }
                else
                {
                    MessageBox.Show("Estatus Actualizados");
                    mostrar_estado();
                    disponibles();
                    ocupado();
                }
            }
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_id_cajon.Text))
            {
                MessageBox.Show("Campo Vacio");
            }
            else
            {
                datos.Id_cajon = int.Parse(txt_id_cajon.Text);




                if (ejecutar.cajon_disponible(datos) == 0)
                {
                    MessageBox.Show("Error al actualizar estatus");
                }
                else
                {
                    MessageBox.Show("Estatus Actualizados");
                    mostrar_estado();
                    disponibles();
                    ocupado();
                }
            }
        }
    }
}
