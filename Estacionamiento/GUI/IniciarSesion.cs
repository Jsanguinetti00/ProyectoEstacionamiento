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
using Estacionamiento.GUI;
using Estacionamiento.DAO;
using System.Runtime.InteropServices;

namespace Estacionamiento
{
    public partial class IniciarSesión : Form
    {
        verificacion_BO datos = new verificacion_BO();
        verificacion_DAO ejecutar = new verificacion_DAO();
        

        public IniciarSesión()
        {
            InitializeComponent();
        }
        int cont;
        private void btn_iniciar_Click(object sender, EventArgs e)
        {

            cont ++;
            if (cont <= 3)
            {
                datos.No_usuario = txt_usuario.Text;
                datos.Contraseña = txt_contraseña.Text;
                if (ejecutar.autentificacion(datos) == true)
                {

                    Form1 v1 = new Form1();
                    v1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario O contraseña incorrecto, verifique sus datos");
                    
                }
            }
            else
            {
                btn_iniciar.Enabled = false;
                dos_pasos v1 = new dos_pasos();
                v1.Show();
                this.Hide();

            }
               
                


                
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_soft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
