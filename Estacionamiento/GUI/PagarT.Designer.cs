namespace Estacionamiento.GUI
{
    partial class PagarT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_cajones = new System.Windows.Forms.DataGridView();
            this.btn_perdio = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.txt_numero_c = new System.Windows.Forms.TextBox();
            this.lbl_codigocliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cajones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_cajones);
            this.groupBox1.Controls.Add(this.btn_perdio);
            this.groupBox1.Controls.Add(this.btn_pagar);
            this.groupBox1.Controls.Add(this.txt_numero_c);
            this.groupBox1.Controls.Add(this.lbl_codigocliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // dtg_cajones
            // 
            this.dtg_cajones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cajones.Location = new System.Drawing.Point(6, 186);
            this.dtg_cajones.Name = "dtg_cajones";
            this.dtg_cajones.Size = new System.Drawing.Size(650, 195);
            this.dtg_cajones.TabIndex = 21;
            // 
            // btn_perdio
            // 
            this.btn_perdio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_perdio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_perdio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_perdio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perdio.ForeColor = System.Drawing.Color.White;
            this.btn_perdio.Image = ((System.Drawing.Image)(resources.GetObject("btn_perdio.Image")));
            this.btn_perdio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_perdio.Location = new System.Drawing.Point(301, 79);
            this.btn_perdio.Name = "btn_perdio";
            this.btn_perdio.Size = new System.Drawing.Size(145, 38);
            this.btn_perdio.TabIndex = 16;
            this.btn_perdio.Text = "Perdió Ticket";
            this.btn_perdio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_perdio.UseVisualStyleBackColor = false;
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_pagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.ForeColor = System.Drawing.Color.White;
            this.btn_pagar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagar.Image")));
            this.btn_pagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagar.Location = new System.Drawing.Point(301, 35);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(145, 38);
            this.btn_pagar.TabIndex = 15;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            // 
            // txt_numero_c
            // 
            this.txt_numero_c.Location = new System.Drawing.Point(158, 42);
            this.txt_numero_c.Name = "txt_numero_c";
            this.txt_numero_c.Size = new System.Drawing.Size(109, 26);
            this.txt_numero_c.TabIndex = 2;
            // 
            // lbl_codigocliente
            // 
            this.lbl_codigocliente.AutoSize = true;
            this.lbl_codigocliente.Location = new System.Drawing.Point(76, 45);
            this.lbl_codigocliente.Name = "lbl_codigocliente";
            this.lbl_codigocliente.Size = new System.Drawing.Size(76, 18);
            this.lbl_codigocliente.TabIndex = 1;
            this.lbl_codigocliente.Text = "Matricula";
            // 
            // PagarT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarT";
            this.Text = "PagarT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cajones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_cajones;
        private System.Windows.Forms.Button btn_perdio;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.TextBox txt_numero_c;
        private System.Windows.Forms.Label lbl_codigocliente;
    }
}