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
    public partial class Empleado : Form
    {
        empleado_DAO ejecutar = new empleado_DAO();
        Empleado_BO datos = new Empleado_BO();
        usuario_BO datosus = new usuario_BO();
        usuario_DAO ejecutarus = new usuario_DAO();
        public Empleado()
        {
            InitializeComponent();
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            txt_id_empleado.Enabled = false;
            Cargar_turnos();
            Cargar_empresa();
            mostrar_div();
            carga_usu();
            mostrar_usu();
        }
        public void mostrar_div()
        {
            dgv_empleado.DataSource = ejecutar.tabla_empleado();
        }
        public void mostrar_usu()
        {
            dgv_Usuario.DataSource = ejecutarus.tabla_usuario();
        }
        private void cmb_tipocuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_empresa = ejecutar.id_empleado(cmb_empresa.Text);
            datos.Fk_id_empresa = int.Parse(fk_id_empresa);
            //MessageBox.Show(fk_id_empresa);
        }

        private void cmb_turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fk_id_turno = ejecutar.id_turno(cmb_turno.Text);
            datos.Fk_id_turno = int.Parse(fk_id_turno);
            //MessageBox.Show(fk_id_turno);
        }

        private void Cargar_turnos()
        {
            cmb_turno.Items.Clear();
            ArrayList ListaFinal = ejecutar.listaturno();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_turno.Items.Add(ListaFinal[i].ToString());
            }
        }
        private void carga_usu()
        {

            cmb_tipocuenta.Items.Clear();
            ArrayList ListaFinal = ejecutarus.listatipo();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_tipocuenta.Items.Add(ListaFinal[i].ToString());
            }
        }
        private void Cargar_empresa()
        {
            cmb_empresa.Items.Clear();
            ArrayList ListaFinal = ejecutar.listaempresa();

            for (int i = 0; i < ListaFinal.Count; i++)
            {
                cmb_empresa.Items.Add(ListaFinal[i].ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_apellidomat.Text)||string.IsNullOrEmpty(txt_apellidopat.Text)   || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_direccion.Text) )
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {

                datos.Apellido_materno = txt_apellidomat.Text;
                datos.Apellido_paterno = txt_apellidopat.Text;
                datos.Curp = txt_curp.Text;
                datos.Direccion = txt_direccion.Text;
                datos.Edad = int.Parse (txt_edad.Text);
                datos.Nombres = txt_nombres.Text;
                datos.Telefono = txt_telefono.Text;
                



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
            if (string.IsNullOrEmpty(txt_id_empleado.Text) || string.IsNullOrEmpty(txt_apellidomat.Text) || string.IsNullOrEmpty(txt_apellidopat.Text) || string.IsNullOrEmpty(txt_edad.Text) || string.IsNullOrEmpty(txt_nombres.Text) || string.IsNullOrEmpty(txt_direccion.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datos.Id_empleado = int.Parse(txt_id_empleado.Text);
                datos.Apellido_materno = txt_apellidomat.Text;
                datos.Apellido_paterno = txt_apellidopat.Text;
                datos.Curp = txt_curp.Text;
                datos.Direccion = txt_direccion.Text;
                datos.Edad = int.Parse(txt_edad.Text);
                datos.Nombres = txt_nombres.Text;
                datos.Telefono = txt_telefono.Text;




                if (ejecutar.actualizar_empleado(datos) == 0)
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_empleado.Text))
            {
                MessageBox.Show("Seleccione un registro para poder eliminar");
            }
            else
            {
                datos.Id_empleado = int.Parse(txt_id_empleado.Text);
                if (ejecutar.eliminar_empleado(datos) == 0)
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
            txt_contraseña.Clear();
            txt_usuario.Clear();
            txt_curp.Clear();
            txt_direccion.Clear();
            txt_edad.Clear();
            txt_id_empleado.Clear();
            txt_nombres.Clear();
            txt_telefono.Clear();
            cmb_empresa.Items.Clear();
            cmb_turno.Items.Clear();
        }

        private void dgv_empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_empleado.Text = dgv_empleado.Rows[fila].Cells[0].Value.ToString();
            txt_curp.Text = dgv_empleado.Rows[fila].Cells[1].Value.ToString();
            txt_nombres.Text = dgv_empleado.Rows[fila].Cells[2].Value.ToString();
            txt_apellidopat.Text = dgv_empleado.Rows[fila].Cells[3].Value.ToString();
            txt_apellidomat.Text = dgv_empleado.Rows[fila].Cells[4].Value.ToString();
            txt_edad.Text = dgv_empleado.Rows[fila].Cells[5].Value.ToString();
            txt_direccion.Text = dgv_empleado.Rows[fila].Cells[6].Value.ToString();
            txt_telefono.Text = dgv_empleado.Rows[fila].Cells[7].Value.ToString();
            cmb_empresa.Text = dgv_empleado.Rows[fila].Cells[8].Value.ToString();
            cmb_turno.Text = dgv_empleado.Rows[fila].Cells[9].Value.ToString();
        }

        private void dgv_empleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_id_empleado.Text = dgv_empleado.Rows[fila].Cells[0].Value.ToString();
            txt_curp.Text = dgv_empleado.Rows[fila].Cells[1].Value.ToString();
            txt_nombres.Text = dgv_empleado.Rows[fila].Cells[2].Value.ToString();
            txt_apellidopat.Text = dgv_empleado.Rows[fila].Cells[3].Value.ToString();
            txt_apellidomat.Text = dgv_empleado.Rows[fila].Cells[4].Value.ToString();
            txt_edad.Text = dgv_empleado.Rows[fila].Cells[5].Value.ToString();
            txt_direccion.Text = dgv_empleado.Rows[fila].Cells[6].Value.ToString();
            txt_telefono.Text = dgv_empleado.Rows[fila].Cells[7].Value.ToString();
            cmb_empresa.Text = dgv_empleado.Rows[fila].Cells[8].Value.ToString();
            cmb_turno.Text = dgv_empleado.Rows[fila].Cells[9].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text)|| string.IsNullOrEmpty(txt_confcontra.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datosus.Usuario = txt_usuario.Text;
                datosus.Fk_id_empleado = int.Parse(txt_fk_id_emple.Text);
                
                if (txt_contraseña.Text==txt_confcontra.Text)
                {
                    datosus.Contraseña = txt_contraseña.Text;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                if (ejecutarus.guardar(datosus) == 0)
                {
                    MessageBox.Show("error al guardar datos");
                }
                else
                {
                    MessageBox.Show("se ha guardado correctamente");
                    mostrar_usu();
                }
            }
        }

        private void btn_editarus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || string.IsNullOrEmpty(txt_confcontra.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                datosus.Usuario = txt_usuario.Text;
                datosus.Fk_id_empleado = int.Parse(txt_fk_id_emple.Text);

                if (txt_contraseña.Text == txt_confcontra.Text)
                {
                    datosus.Contraseña = txt_contraseña.Text;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                if (ejecutarus.actualizar_usuarios(datosus) == 0)
                {
                    MessageBox.Show("error al editar datos");
                }
                else
                {
                    MessageBox.Show("se han editado los datos seleccionados");
                    mostrar_usu();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgv_empleado.Visible==false)
            {
                dgv_Usuario.Hide();
                dgv_empleado.Show();
            }
        }

        private void btn_verusu_Click(object sender, EventArgs e)
        {
            if(dgv_Usuario.Visible==false)
            {
                dgv_Usuario.Show();
                dgv_empleado.Hide();
            }
        }

        private void cmb_tipocuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string fk_id_tipo_cuenta = ejecutarus.id_tipo_cuenta(cmb_tipocuenta.Text);
            datosus.Fk_id_tipo_cuenta = int.Parse(fk_id_tipo_cuenta);
            //MessageBox.Show(fk_id_tipo_cuenta);
        }

        private void btn_eliminarus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || string.IsNullOrEmpty(txt_confcontra.Text))
            {
                MessageBox.Show("el campo no tiene un valor o Introdujo un dato incorrecto");
            }
            else
            {
                
                datosus.Fk_id_empleado = int.Parse(txt_fk_id_emple.Text);

                
                if (ejecutarus.eliminar_usuario(datosus) == 0)
                {
                    MessageBox.Show("error al eliminar datos");
                }
                else
                {
                    MessageBox.Show("se han borrado los datos seleccionados");
                    mostrar_usu();
                }
            }
        }

        private void dgv_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_Usuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void gpb_info_g_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
