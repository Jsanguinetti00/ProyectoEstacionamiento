using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Estacionamiento.BO;
using Estacionamiento.GUI;
using System.Runtime.InteropServices;



namespace Estacionamiento.GUI
{
    public partial class dos_pasos : Form
    {
        mensaje_BO objmensa = new mensaje_BO();
        public dos_pasos()
        {
            InitializeComponent();
        }


        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_telefono.Text))
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                if (txt_codigo.Visible == false && btn_codigo.Visible == false && lbl_codigo.Visible == false)
                {
                    txt_codigo.Visible = true;
                    btn_codigo.Visible = true;
                    lbl_codigo.Visible = true;
                }
                Random r = new Random();
                objmensa.Codigoveri = r.Next(10000, 99999);
                objmensa.Numero = Int64.Parse(txt_telefono.Text);
                const string accountSid = "AC74db81c7f5c3209705c901704effcc3d";
                const string authToken = "ea6c327bb3c132797d8569e68d70d1ee";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: objmensa.Codigoveri.ToString(),
                    from: new Twilio.Types.PhoneNumber("+17278608175"),
                    to: new Twilio.Types.PhoneNumber(objmensa.conversion())
                );

                Console.WriteLine(message.Sid);
                MessageBox.Show("Codigo de verificacion enviado, por favor compruebe su bandeja de mensajes");
            }
            
        }

        private void btn_codigo_Click(object sender, EventArgs e)
        {
            btn_codigo.Visible = false;
            objmensa.Comproveri = int.Parse(txt_codigo.Text);

            if (objmensa.Comproveri == objmensa.Codigoveri)
            {
                MessageBox.Show("Verificado Exitosamente");
                IniciarSesión v1 = new IniciarSesión();
                v1.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error Al Verificarse");
                btn_codigo.Visible = true;
            }
        }

        private void dos_pasos_Load(object sender, EventArgs e)
        {

        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
