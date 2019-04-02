namespace Estacionamiento.GUI
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_numdisp = new System.Windows.Forms.Label();
            this.lbl_cajones = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_numocup = new System.Windows.Forms.Label();
            this.lbl_cajonesuso = new System.Windows.Forms.Label();
            this.dgv_estado = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tmr_fecha = new System.Windows.Forms.Timer(this.components);
            this.id_cajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_cajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id_cajon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_numdisp);
            this.panel2.Controls.Add(this.lbl_cajones);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 140);
            this.panel2.TabIndex = 1;
            // 
            // lbl_numdisp
            // 
            this.lbl_numdisp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_numdisp.AutoSize = true;
            this.lbl_numdisp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numdisp.Font = new System.Drawing.Font("Adobe Gothic Std B", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_numdisp.ForeColor = System.Drawing.Color.White;
            this.lbl_numdisp.Location = new System.Drawing.Point(27, 95);
            this.lbl_numdisp.Name = "lbl_numdisp";
            this.lbl_numdisp.Size = new System.Drawing.Size(30, 34);
            this.lbl_numdisp.TabIndex = 14;
            this.lbl_numdisp.Text = "0";
            // 
            // lbl_cajones
            // 
            this.lbl_cajones.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cajones.AutoSize = true;
            this.lbl_cajones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cajones.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cajones.ForeColor = System.Drawing.Color.White;
            this.lbl_cajones.Location = new System.Drawing.Point(63, 102);
            this.lbl_cajones.Name = "lbl_cajones";
            this.lbl_cajones.Size = new System.Drawing.Size(200, 24);
            this.lbl_cajones.TabIndex = 13;
            this.lbl_cajones.Text = "Cajones disponibles";
            this.lbl_cajones.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.lbl_numocup);
            this.panel9.Controls.Add(this.lbl_cajonesuso);
            this.panel9.Location = new System.Drawing.Point(298, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 140);
            this.panel9.TabIndex = 16;
            // 
            // lbl_numocup
            // 
            this.lbl_numocup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_numocup.AutoSize = true;
            this.lbl_numocup.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numocup.Font = new System.Drawing.Font("Adobe Gothic Std B", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_numocup.ForeColor = System.Drawing.Color.White;
            this.lbl_numocup.Location = new System.Drawing.Point(32, 95);
            this.lbl_numocup.Name = "lbl_numocup";
            this.lbl_numocup.Size = new System.Drawing.Size(30, 34);
            this.lbl_numocup.TabIndex = 14;
            this.lbl_numocup.Text = "0";
            // 
            // lbl_cajonesuso
            // 
            this.lbl_cajonesuso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_cajonesuso.AutoSize = true;
            this.lbl_cajonesuso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cajonesuso.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_cajonesuso.ForeColor = System.Drawing.Color.White;
            this.lbl_cajonesuso.Location = new System.Drawing.Point(88, 102);
            this.lbl_cajonesuso.Name = "lbl_cajonesuso";
            this.lbl_cajonesuso.Size = new System.Drawing.Size(156, 24);
            this.lbl_cajonesuso.TabIndex = 13;
            this.lbl_cajonesuso.Text = "Cajones en uso";
            // 
            // dgv_estado
            // 
            this.dgv_estado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cajon,
            this.estatus,
            this.tipo_de_cajon,
            this.nombre});
            this.dgv_estado.Location = new System.Drawing.Point(12, 158);
            this.dgv_estado.Name = "dgv_estado";
            this.dgv_estado.Size = new System.Drawing.Size(770, 327);
            this.dgv_estado.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(584, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 140);
            this.panel12.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarifa por hora";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(790, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 140);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Día";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tarifa actual";
            // 
            // btn_asignar
            // 
            this.btn_asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(69)))), ((int)(((byte)(152)))));
            this.btn_asignar.FlatAppearance.BorderSize = 0;
            this.btn_asignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asignar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_asignar.ForeColor = System.Drawing.Color.White;
            this.btn_asignar.Location = new System.Drawing.Point(791, 200);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(200, 48);
            this.btn_asignar.TabIndex = 21;
            this.btn_asignar.Text = "Asignar vehiculo";
            this.btn_asignar.UseVisualStyleBackColor = false;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(69)))), ((int)(((byte)(152)))));
            this.btn_retirar.FlatAppearance.BorderSize = 0;
            this.btn_retirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retirar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_retirar.ForeColor = System.Drawing.Color.White;
            this.btn_retirar.Location = new System.Drawing.Point(790, 254);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(200, 48);
            this.btn_retirar.TabIndex = 22;
            this.btn_retirar.Text = "Retirar vehiculo";
            this.btn_retirar.UseVisualStyleBackColor = false;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_hora);
            this.panel4.Controls.Add(this.lbl_fecha);
            this.panel4.Location = new System.Drawing.Point(790, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 177);
            this.panel4.TabIndex = 20;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hora.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(34, 108);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(90, 24);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.Text = "00:00:00";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(3, 74);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(55, 24);
            this.lbl_fecha.TabIndex = 14;
            this.lbl_fecha.Text = "0/0/0";
            this.lbl_fecha.Click += new System.EventHandler(this.lbl_fecha_Click);
            // 
            // tmr_fecha
            // 
            this.tmr_fecha.Tick += new System.EventHandler(this.tmr_fecha_Tick);
            // 
            // id_cajon
            // 
            this.id_cajon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_cajon.DataPropertyName = "id_cajon";
            this.id_cajon.HeaderText = "Numero De Cajon";
            this.id_cajon.Name = "id_cajon";
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.DataPropertyName = "estatus";
            this.estatus.HeaderText = "Estado";
            this.estatus.Name = "estatus";
            this.estatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tipo_de_cajon
            // 
            this.tipo_de_cajon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_de_cajon.DataPropertyName = "tipo_de_cajon";
            this.tipo_de_cajon.HeaderText = "Tipo De Cajon";
            this.tipo_de_cajon.Name = "tipo_de_cajon";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Visible = false;
            // 
            // txt_id_cajon
            // 
            this.txt_id_cajon.Location = new System.Drawing.Point(790, 174);
            this.txt_id_cajon.Name = "txt_id_cajon";
            this.txt_id_cajon.Size = new System.Drawing.Size(199, 20);
            this.txt_id_cajon.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(794, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Numero de cajon";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_cajon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dgv_estado);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "InicioSesion";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_numdisp;
        private System.Windows.Forms.Label lbl_cajones;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_numocup;
        private System.Windows.Forms.Label lbl_cajonesuso;
        private System.Windows.Forms.DataGridView dgv_estado;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Timer tmr_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cajon;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_cajon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.TextBox txt_id_cajon;
        private System.Windows.Forms.Label label1;
    }
}