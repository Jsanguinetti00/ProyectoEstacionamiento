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
    public partial class CajonesyT : Form
    {
        tarifa_DAO ejecutartar = new tarifa_DAO();
        cajon_BO datos = new cajon_BO();
        cajon_DAO ejecutar = new cajon_DAO();

        public CajonesyT()
        {
            InitializeComponent();
        }

        private void cmb_nombreestacionamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_estacionamiento = ejecutar.id_estacionamiento(cmb_nombreestacionamiento.Text);
            datos.Fk_id_estacionamiento = int.Parse(fk_id_estacionamiento);
            //MessageBox.Show(fk_id_estacionamiento);
        }
        public void mostrar_tarifa()
        {
            dgv_tarifa.DataSource = ejecutartar.tabla_tarifa();
        }
        private void Cargar_estacionamiento()
        {
            cmb_nombreestacionamiento.Items.Clear();
            ArrayList ListaFinal = ejecutar.listaestacionamiento();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_nombreestacionamiento.Items.Add(ListaFinal[i].ToString());
            }
        }

        private void Cargar_tipocajon()
        {
            cmb_tipo.Items.Clear();
            ArrayList ListaFinal = ejecutar.listacajon();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_tipo.Items.Add(ListaFinal[i].ToString());
            }
        }

        private void CajonesyT_Load(object sender, EventArgs e)
        {
            Cargar_estacionamiento();
            Cargar_tipocajon();
            mostrar_div();
            mostrar_tarifa();
        }

        public void mostrar_div()
        {
            dtg_cajones.DataSource = ejecutar.tabla_cajon();
        }

        private void cmb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_tipo = ejecutar.id_tipocajon(cmb_tipo.Text);
            datos.Fk_id_tipocajon = int.Parse(fk_id_tipo);
            //MessageBox.Show(fk_id_tipo);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
           
                if ( string.IsNullOrEmpty(cmb_tipo.Text) || string.IsNullOrEmpty(cmb_nombreestacionamiento.Text) || string.IsNullOrEmpty(cmb_estado.Text))
                {
                    MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
                }
                else
                {
                
                    datos.Gencajon = int.Parse(txt_generarcajones.Text);
                    datos.Estatus = cmb_estado.Text;
                


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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(cmb_tipo.Text) || string.IsNullOrEmpty(cmb_nombreestacionamiento.Text) || string.IsNullOrEmpty(cmb_estado.Text) || string.IsNullOrEmpty(txt_cajon.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                
                datos.Id_cajon = int.Parse(txt_cajon.Text);
               
                


                if (ejecutar.actualizar_cajon(datos) == 0)
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

        private void dgv_tarifa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_cajones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_cajon.Text = dtg_cajones.Rows[fila].Cells[0].Value.ToString();
            cmb_estado.Text = dtg_cajones.Rows[fila].Cells[1].Value.ToString();
            cmb_tipo.Text = dtg_cajones.Rows[fila].Cells[2].Value.ToString();
            cmb_nombreestacionamiento.Text = dtg_cajones.Rows[fila].Cells[3].Value.ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(txt_cajon.Text) )
                {
                    MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
                }
                else
                {

                    datos.Id_cajon = int.Parse(txt_cajon.Text);




                    if (ejecutar.eliminar_cajon(datos) == 0)
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
    }
}
