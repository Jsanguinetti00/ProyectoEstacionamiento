using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Estacionamiento.GUI;
using Estacionamiento.BO;
using Estacionamiento.DAO;

namespace Estacionamiento
{
    public partial class Form1 : Form
    {
        cliente_BO datos = new cliente_BO();
        cliente_DAO ejecutar = new cliente_DAO();


        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_ocultarm_Tick(object sender, EventArgs e)
        {
            if (pnl_menu.Width <=40)
            {
                tmr_ocultarm.Enabled = false;
            }
            else
            {
                pnl_menu.Width = pnl_menu.Width - 20;
            }
        }

        private void tmr_abrirm_Tick(object sender, EventArgs e)
        {
            if (pnl_menu.Width >= 200)
            {
                tmr_abrirm.Enabled = false;
            }
            else
            {
                pnl_menu.Width = pnl_menu.Width + 20;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pnl_menu.Width == 200)
            {
                if (tmr_abrirm.Enabled == true)
                {
                    
                }
                else
                {
                    tmr_ocultarm.Enabled = true;
                }
            }
            else
            {
                if (tmr_ocultarm.Enabled == true) { }
                else
                {
                    tmr_abrirm.Enabled = true;
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirformhija(new Inicio());
            this.Height = 0;
            tmr_abrir_frm.Enabled = true;
        }

        private void tmr_abrirop_Tick(object sender, EventArgs e)
        {
            if (pnl_config.Height >= 140)
            {
                tmr_abrirop.Enabled = false;
            }
            else
            {
                pnl_config.Height = pnl_config.Height + 20;
            }
        }
        private void tmr_ocultarop_Tick(object sender, EventArgs e)
        {
            if (pnl_config.Height <= 0)
            {
                tmr_ocultarop.Enabled = false;
            }
            else
            {
                pnl_config.Height = pnl_config.Height - 20;
            }
        }

        private void btn_opciones_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_opciones_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            abrirformhija(new Cliente());
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            abrirformhija(new Inicio());
        }

        public void abrirformhija(object abrirform)
        {
            if (this.pnl_inicio.Controls.Count > 0)
                this.pnl_inicio.Controls.RemoveAt(0);
            Form fh = abrirform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_inicio.Controls.Add(fh);
            this.pnl_inicio.Tag = fh;
            fh.Show();

        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn_genrar_t_Click(object sender, EventArgs e)
        {
            abrirformhija(new GTicket());
        }

        private void tmr_abrir_frm_Tick(object sender, EventArgs e)
        {
            if (this.Height >= 700)
            {
                tmr_abrir_frm.Enabled = false;
            }
            else
            {
                this.Height = this.Height + 20;
            }
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            abrirformhija(new Empleado());
        }

        private void btn_generar_rep_Click(object sender, EventArgs e)
        {
            abrirformhija(new Reporte());
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            if (pnl_config.Height == 140)
            {
                if (tmr_abrirop.Enabled == true) { }
                else
                {
                    tmr_ocultarop.Enabled = true;
                }
            }
            else
            {
                if (tmr_ocultarop.Enabled == true) { }
                else
                {
                    tmr_abrirop.Enabled = true;
                }
            }
        }

        private void pnl_opciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_opciones_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ticket_p_Click(object sender, EventArgs e)
        {
            abrirformhija(new PagarT());
        }

        private void btn_genrar_con_Click(object sender, EventArgs e)
        {
            abrirformhija(new Contrato());
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            abrirformhija(new Servicios());
        }

        private void btn_realizar_c_Click(object sender, EventArgs e)
        {
            abrirformhija(new corte());
        }

        private void btn_cajones_Click(object sender, EventArgs e)
        {
            abrirformhija(new CajonesyT());
        }

        private void btn_turnos_Click(object sender, EventArgs e)
        {
            abrirformhija(new Turnos());
        }

        private void pnl_inicio_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
