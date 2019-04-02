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
    public partial class Servicios : Form
    {
        pago_servicio_BO datospag = new pago_servicio_BO();
        pago_servicios_DAO ejecutarpag = new pago_servicios_DAO();
        tipo_servicio_DAO ejecutar = new tipo_servicio_DAO();
        tipo_servicios_BO datos = new tipo_servicios_BO();
        public Servicios()
        {
            InitializeComponent();
        }

        private void btn_agregarservicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombreservicio.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Tipo_servicio = txt_nombreservicio.Text;

                if (ejecutar.guardar(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");
                    mostrar_tiposervicios();
                }
            }
        }
        public void mostrar_tiposervicios()
        {
            dtg_tiposervicios.DataSource = ejecutar.tabla_tipo_servicios();
        }
        public void mostrar_pagoserv()
        {
            dtg_pagoser.DataSource = ejecutarpag.tabla_pagserv();
        }

        private void btn_actualizarservicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombreservicio.Text) || string.IsNullOrEmpty(txt_id_servicio.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Id_servicio = int.Parse(txt_id_servicio.Text);
                datos.Tipo_servicio = txt_nombreservicio.Text;

                if (ejecutar.actualizar_tipo_servicios(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Guardados");
                    mostrar_tiposervicios();
                }
            }
        }

        private void btn_eliminarservicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_servicio.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Id_servicio = int.Parse(txt_id_servicio.Text);


                if (ejecutar.eliminar_servicio(datos) == 0)
                {
                    MessageBox.Show("Error al guardar datos");
                }
                else
                {
                    MessageBox.Show("Datos Eliminados");
                    mostrar_tiposervicios();
                }
            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            mostrar_tiposervicios();
            mostrar_pagoserv();
            Cargar_servi();
        }
        private void Cargar_servi()
        {
            cmb_pagser.Items.Clear();
            ArrayList ListaFinal = ejecutarpag.listapagser();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_pagser.Items.Add(ListaFinal[i].ToString());
            }
        }

        private void dtg_tiposervicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_servicio.Text = dtg_tiposervicios.Rows[fila].Cells[0].Value.ToString();
            txt_nombreservicio.Text = dtg_tiposervicios.Rows[fila].Cells[1].Value.ToString();
        }

        private void dtg_tiposervicios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_servicio.Text = dtg_tiposervicios.Rows[fila].Cells[0].Value.ToString();
            txt_nombreservicio.Text = dtg_tiposervicios.Rows[fila].Cells[1].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_servicio = ejecutarpag.id_servicio(cmb_pagser.Text);
            datospag.Fk_id_servicio = int.Parse(fk_id_servicio);
            MessageBox.Show(fk_id_servicio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_servicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_pagoser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmb_pagser.Text) || string.IsNullOrEmpty(txt_pagserv.Text))
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                datospag.Total_pago = double.Parse(txt_pagserv.Text);
                if(ejecutarpag.pagar_srvicior(datospag) == 0)
                {
                    MessageBox.Show("Error al guardar los datos");
                }
            }
        }
    }
}
