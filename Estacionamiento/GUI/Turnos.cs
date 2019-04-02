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
    public partial class Turnos : Form
    {
        turno_BO datos = new turno_BO();
        turnos_DAO ejecutar = new turnos_DAO();
        public Turnos()
        {
            InitializeComponent();
        }

        private void dtg_turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombreturno.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                
                datos.Nombre_turno = txt_nombreturno.Text;
                datos.Hora_final = dtp_horafinal.Text.ToString();
                datos.Hora_inicial = dtp_horainicial.Text.ToString();



                if (ejecutar.guardar(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");

                }
            }
            mostrar_turnos();




        }

        private void btn_eliminarturno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idturno.Text))
            {
                MessageBox.Show("Seleccione un registro para poder eliminar");
            }
            else
            {
                datos.Id_turno = int.Parse(txt_idturno.Text);
                if (ejecutar.eliminar_turno(datos) == 0)
                {
                    MessageBox.Show("error al borrar datos");
                }
                else
                {
                    MessageBox.Show("se han borrado los datos seleccionados");

                }
            }
            mostrar_turnos();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_idturno.Clear();
            txt_nombreturno.Clear();
            
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            mostrar_turnos();
        }
        public void mostrar_turnos()
        {
            dgv_turnos.DataSource = ejecutar.tabla_turnos();
        }

        private void dgv_turnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_turnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_idturno.Text = dgv_turnos.Rows[fila].Cells[0].Value.ToString();
            dtp_horainicial.Text = dgv_turnos.Rows[fila].Cells[1].Value.ToString();
            dtp_horafinal.Text = dgv_turnos.Rows[fila].Cells[2].Value.ToString();
            txt_nombreturno.Text = dgv_turnos.Rows[fila].Cells[3].Value.ToString();
        }

        private void btn_editarturno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombreturno.Text)||string.IsNullOrEmpty(txt_idturno.Text) )
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                datos.Id_turno = int.Parse(txt_idturno.Text);
                datos.Nombre_turno = txt_nombreturno.Text;
                datos.Hora_final = dtp_horafinal.Text.ToString();
                datos.Hora_inicial = dtp_horainicial.Text.ToString();



                if (ejecutar.actualizar_turno(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");

                }
            }
            mostrar_turnos();
        }

        private void dtp_horainicial_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
