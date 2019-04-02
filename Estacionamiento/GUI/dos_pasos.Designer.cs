namespace Estacionamiento.GUI
{
    partial class dos_pasos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dos_pasos));
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_codigo = new System.Windows.Forms.Button();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(36, 207);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(240, 20);
            this.txt_codigo.TabIndex = 25;
            this.txt_codigo.Visible = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(36, 87);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(240, 20);
            this.txt_telefono.TabIndex = 24;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(36, 113);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(240, 36);
            this.btn_enviar.TabIndex = 23;
            this.btn_enviar.Text = "enviar codigo";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(46, 181);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(70, 23);
            this.lbl_codigo.TabIndex = 22;
            this.lbl_codigo.Text = "codigo";
            this.lbl_codigo.Visible = false;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.BackColor = System.Drawing.Color.Transparent;
            this.lbl_telefono.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Black;
            this.lbl_telefono.Location = new System.Drawing.Point(46, 61);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(83, 23);
            this.lbl_telefono.TabIndex = 21;
            this.lbl_telefono.Text = "telefono";
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pnl_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_titulo.Controls.Add(this.button1);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Location = new System.Drawing.Point(-1, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(318, 43);
            this.pnl_titulo.TabIndex = 26;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(275, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 43);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Software Estacionamiento";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btn_codigo
            // 
            this.btn_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_codigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_codigo.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_codigo.ForeColor = System.Drawing.Color.White;
            this.btn_codigo.Location = new System.Drawing.Point(36, 233);
            this.btn_codigo.Name = "btn_codigo";
            this.btn_codigo.Size = new System.Drawing.Size(240, 36);
            this.btn_codigo.TabIndex = 27;
            this.btn_codigo.Text = "validar";
            this.btn_codigo.UseVisualStyleBackColor = false;
            this.btn_codigo.Visible = false;
            this.btn_codigo.Click += new System.EventHandler(this.btn_codigo_Click);
            // 
            // dos_pasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 318);
            this.Controls.Add(this.btn_codigo);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_telefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dos_pasos";
            this.Text = "dos_pasos";
            this.Load += new System.EventHandler(this.dos_pasos_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_codigo;
    }
}