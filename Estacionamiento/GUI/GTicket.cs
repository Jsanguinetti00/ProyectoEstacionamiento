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

namespace Estacionamiento.GUI
{
    public partial class GTicket : Form
    {
        public GTicket()
        {
            InitializeComponent();
        }

        tickets_BO datos = new tickets_BO();
        tickets_DAO ejecutar = new tickets_DAO();

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matricula.Text) || string.IsNullOrEmpty(dtp_fechahora_entrada.Text))
            {
                MessageBox.Show("Llena todos los campos para continuar");
            }
            else
            {
                datos.Matricula = txt_matricula.Text;
                datos.Fecha_hora_entrada = Convert.ToDateTime(dtp_fechahora_entrada.Text);
                datos.Fk_id_cajon = int.Parse(cmb_cajones.Text);
                if (ejecutar.guardar(datos) == 0)
                {
                    MessageBox.Show("Error al guardar los datos");
                }
                else
                {
                    MessageBox.Show("Datos guardados en la base de datos");
                }
                mostrar_ticket();
            }
        }

        private void Cargar_empleados()
        {
            cmb_empleado.Items.Clear();
            ArrayList ListaFinal = ejecutar.listaempleados();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_empleado.Items.Add(ListaFinal[i].ToString());
            }
        }


        private void Cargar_cajones()
        {
            cmb_cajones.Items.Clear();
            ArrayList ListaFinal = ejecutar.listacajones();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_cajones.Items.Add(ListaFinal[i].ToString());
            }
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

        private void GTicket_Load(object sender, EventArgs e)
        {
            mostrar_ticket();
            Cargar_empleados();
            Cargar_tarifa();
            Cargar_cajones();

        }
        private void mostrar_ticket()
        {
            dgv_tickets.DataSource = ejecutar.tabla_ticket();
        }

        private void cmb_tarifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_tarifa = ejecutar.id_tarifa(cmb_tarifa.Text);
            datos.Fk_id_tarifa = int.Parse(fk_id_tarifa);
            MessageBox.Show(fk_id_tarifa);
        }


        private void cmb_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_empleado = ejecutar.id_empleado(cmb_empleado.Text);
            datos.Fk_id_empleado = int.Parse(fk_id_empleado);
            MessageBox.Show(fk_id_empleado);
        }

        private void btn_pagarticket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtp_fechahorasalida.Text) || string.IsNullOrEmpty(txt_total_pagar.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Total_pagar = double.Parse(txt_total_pagar.Text);
                datos.Fecha_hora_salida = Convert.ToDateTime(dtp_fechahorasalida.Text);



                if (ejecutar.actualizar_ticket(datos) == 0)
                {
                    MessageBox.Show("Error al actualizar datos");
                }
                else
                {
                    MessageBox.Show("Datos Actualizados");
                    mostrar_ticket();
                }
            }

        }

        private void dgv_tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_folio.Text = dgv_tickets.Rows[fila].Cells["folio_ticket"].Value.ToString();
            txt_matricula.Text = dgv_tickets.Rows[fila].Cells["matricula"].Value.ToString();
            dtp_fechahora_entrada.Text = dgv_tickets.Rows[fila].Cells["fecha_hora_de_entrada"].Value.ToString();
            cmb_cajones.Text = dgv_tickets.Rows[fila].Cells["fk_id_cajon"].Value.ToString();
            cmb_empleado.Text = dgv_tickets.Rows[fila].Cells["fk_id_empleado"].Value.ToString();
            cmb_tarifa.Text = dgv_tickets.Rows[fila].Cells["fk_id_tarifa"].Value.ToString();
        }

        private void txt_hora_entrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtp_fechahora_entrada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_cajones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fk_id_cajon = ejecutar.id_cajon(cmb_cajones.Text);
            datos.Fk_id_cajon = int.Parse(fk_id_cajon);
            MessageBox.Show(fk_id_cajon);
        }
    }

   

}

