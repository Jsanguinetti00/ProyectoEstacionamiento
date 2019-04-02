namespace Estacionamiento.GUI
{
    partial class GTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GTicket));
            this.gpb_generar = new System.Windows.Forms.GroupBox();
            this.btn_pagarticket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tarifa = new System.Windows.Forms.ComboBox();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_codigocliente = new System.Windows.Forms.Label();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.folio_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hora_de_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_cajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_corte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.dtp_fechahora_entrada = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechahorasalida = new System.Windows.Forms.DateTimePicker();
            this.cmb_cajones = new System.Windows.Forms.ComboBox();
            this.txt_total_pagar = new System.Windows.Forms.TextBox();
            this.gpb_generar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_generar
            // 
            this.gpb_generar.Controls.Add(this.txt_total_pagar);
            this.gpb_generar.Controls.Add(this.cmb_cajones);
            this.gpb_generar.Controls.Add(this.dtp_fechahorasalida);
            this.gpb_generar.Controls.Add(this.dtp_fechahora_entrada);
            this.gpb_generar.Controls.Add(this.txt_folio);
            this.gpb_generar.Controls.Add(this.label7);
            this.gpb_generar.Controls.Add(this.btn_pagarticket);
            this.gpb_generar.Controls.Add(this.label8);
            this.gpb_generar.Controls.Add(this.cmb_empleado);
            this.gpb_generar.Controls.Add(this.label6);
            this.gpb_generar.Controls.Add(this.label5);
            this.gpb_generar.Controls.Add(this.label4);
            this.gpb_generar.Controls.Add(this.cmb_tarifa);
            this.gpb_generar.Controls.Add(this.btn_retirar);
            this.gpb_generar.Controls.Add(this.btn_generar);
            this.gpb_generar.Controls.Add(this.label3);
            this.gpb_generar.Controls.Add(this.label2);
            this.gpb_generar.Controls.Add(this.txt_matricula);
            this.gpb_generar.Controls.Add(this.lbl_codigocliente);
            this.gpb_generar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.gpb_generar.Location = new System.Drawing.Point(86, 12);
            this.gpb_generar.Name = "gpb_generar";
            this.gpb_generar.Size = new System.Drawing.Size(743, 283);
            this.gpb_generar.TabIndex = 0;
            this.gpb_generar.TabStop = false;
            this.gpb_generar.Text = "Generar ticket";
            // 
            // btn_pagarticket
            // 
            this.btn_pagarticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_pagarticket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pagarticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pagarticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarticket.ForeColor = System.Drawing.Color.White;
            this.btn_pagarticket.Image = ((System.Drawing.Image)(resources.GetObject("btn_pagarticket.Image")));
            this.btn_pagarticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pagarticket.Location = new System.Drawing.Point(481, 239);
            this.btn_pagarticket.Name = "btn_pagarticket";
            this.btn_pagarticket.Size = new System.Drawing.Size(123, 38);
            this.btn_pagarticket.TabIndex = 27;
            this.btn_pagarticket.Text = "Pagar";
            this.btn_pagarticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pagarticket.UseVisualStyleBackColor = false;
            this.btn_pagarticket.Click += new System.EventHandler(this.btn_pagarticket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha y Hora de salida";
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.Font = new System.Drawing.Font("Arial Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(153, 125);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(206, 23);
            this.cmb_empleado.TabIndex = 23;
            this.cmb_empleado.SelectedIndexChanged += new System.EventHandler(this.cmb_empleado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cajón";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total a pagar";
            // 
            // cmb_tarifa
            // 
            this.cmb_tarifa.Font = new System.Drawing.Font("Arial Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.cmb_tarifa.FormattingEnabled = true;
            this.cmb_tarifa.Location = new System.Drawing.Point(552, 86);
            this.cmb_tarifa.Name = "cmb_tarifa";
            this.cmb_tarifa.Size = new System.Drawing.Size(168, 23);
            this.cmb_tarifa.TabIndex = 17;
            this.cmb_tarifa.SelectedIndexChanged += new System.EventHandler(this.cmb_tarifa_SelectedIndexChanged);
            // 
            // btn_retirar
            // 
            this.btn_retirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_retirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_retirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_retirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retirar.ForeColor = System.Drawing.Color.White;
            this.btn_retirar.Image = ((System.Drawing.Image)(resources.GetObject("btn_retirar.Image")));
            this.btn_retirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_retirar.Location = new System.Drawing.Point(162, 239);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(123, 38);
            this.btn_retirar.TabIndex = 16;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_retirar.UseVisualStyleBackColor = false;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_generar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_generar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar.ForeColor = System.Drawing.Color.White;
            this.btn_generar.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar.Image")));
            this.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar.Location = new System.Drawing.Point(33, 239);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(123, 38);
            this.btn_generar.TabIndex = 15;
            this.btn_generar.Text = "Generar";
            this.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarifa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha y Hora de entrada";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_matricula.Location = new System.Drawing.Point(153, 87);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(168, 23);
            this.txt_matricula.TabIndex = 2;
            // 
            // lbl_codigocliente
            // 
            this.lbl_codigocliente.AutoSize = true;
            this.lbl_codigocliente.Location = new System.Drawing.Point(19, 84);
            this.lbl_codigocliente.Name = "lbl_codigocliente";
            this.lbl_codigocliente.Size = new System.Drawing.Size(93, 23);
            this.lbl_codigocliente.TabIndex = 1;
            this.lbl_codigocliente.Text = "Matricula";
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio_ticket,
            this.fecha_hora_de_entrada,
            this.fecha_hora_salida,
            this.total_pagar,
            this.matricula,
            this.nombre,
            this.fk_id_cajon,
            this.fk_id_corte});
            this.dgv_tickets.Location = new System.Drawing.Point(86, 301);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.Size = new System.Drawing.Size(743, 228);
            this.dgv_tickets.TabIndex = 1;
            this.dgv_tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            // 
            // folio_ticket
            // 
            this.folio_ticket.DataPropertyName = "folio_ticket";
            this.folio_ticket.HeaderText = "Folio Ticket";
            this.folio_ticket.Name = "folio_ticket";
            this.folio_ticket.ReadOnly = true;
            // 
            // fecha_hora_de_entrada
            // 
            this.fecha_hora_de_entrada.DataPropertyName = "fecha_hora_entrada";
            this.fecha_hora_de_entrada.HeaderText = "Hora de entrada";
            this.fecha_hora_de_entrada.Name = "fecha_hora_de_entrada";
            this.fecha_hora_de_entrada.ReadOnly = true;
            // 
            // fecha_hora_salida
            // 
            this.fecha_hora_salida.DataPropertyName = "fecha_hora_salida";
            this.fecha_hora_salida.HeaderText = "Hora de salida";
            this.fecha_hora_salida.Name = "fecha_hora_salida";
            this.fecha_hora_salida.ReadOnly = true;
            // 
            // total_pagar
            // 
            this.total_pagar.DataPropertyName = "total_pagar";
            this.total_pagar.HeaderText = "Total a pagar";
            this.total_pagar.Name = "total_pagar";
            this.total_pagar.ReadOnly = true;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matricula";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Empleado";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fk_id_cajon
            // 
            this.fk_id_cajon.DataPropertyName = "fk_id_cajon";
            this.fk_id_cajon.HeaderText = "Numero de cajon";
            this.fk_id_cajon.Name = "fk_id_cajon";
            this.fk_id_cajon.ReadOnly = true;
            // 
            // fk_id_corte
            // 
            this.fk_id_corte.DataPropertyName = "fk_id_corte";
            this.fk_id_corte.HeaderText = "Numero de corte";
            this.fk_id_corte.Name = "fk_id_corte";
            this.fk_id_corte.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Folio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_folio
            // 
            this.txt_folio.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_folio.Location = new System.Drawing.Point(153, 45);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(168, 23);
            this.txt_folio.TabIndex = 29;
            // 
            // dtp_fechahora_entrada
            // 
            this.dtp_fechahora_entrada.Checked = false;
            this.dtp_fechahora_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_fechahora_entrada.Location = new System.Drawing.Point(262, 160);
            this.dtp_fechahora_entrada.Name = "dtp_fechahora_entrada";
            this.dtp_fechahora_entrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_fechahora_entrada.Size = new System.Drawing.Size(342, 30);
            this.dtp_fechahora_entrada.TabIndex = 30;
            this.dtp_fechahora_entrada.Value = new System.DateTime(2019, 4, 2, 7, 42, 52, 0);
            this.dtp_fechahora_entrada.ValueChanged += new System.EventHandler(this.dtp_fechahora_entrada_ValueChanged);
            // 
            // dtp_fechahorasalida
            // 
            this.dtp_fechahorasalida.Checked = false;
            this.dtp_fechahorasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_fechahorasalida.Location = new System.Drawing.Point(262, 195);
            this.dtp_fechahorasalida.Name = "dtp_fechahorasalida";
            this.dtp_fechahorasalida.Size = new System.Drawing.Size(342, 30);
            this.dtp_fechahorasalida.TabIndex = 31;
            this.dtp_fechahorasalida.Value = new System.DateTime(2019, 4, 2, 8, 31, 26, 0);
            // 
            // cmb_cajones
            // 
            this.cmb_cajones.Font = new System.Drawing.Font("Arial Black", 8.5F, System.Drawing.FontStyle.Bold);
            this.cmb_cajones.FormattingEnabled = true;
            this.cmb_cajones.Location = new System.Drawing.Point(552, 48);
            this.cmb_cajones.Name = "cmb_cajones";
            this.cmb_cajones.Size = new System.Drawing.Size(168, 23);
            this.cmb_cajones.TabIndex = 32;
            this.cmb_cajones.SelectedIndexChanged += new System.EventHandler(this.cmb_cajones_SelectedIndexChanged);
            // 
            // txt_total_pagar
            // 
            this.txt_total_pagar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_total_pagar.Location = new System.Drawing.Point(552, 122);
            this.txt_total_pagar.Name = "txt_total_pagar";
            this.txt_total_pagar.Size = new System.Drawing.Size(168, 23);
            this.txt_total_pagar.TabIndex = 33;
            // 
            // GTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.Controls.Add(this.dgv_tickets);
            this.Controls.Add(this.gpb_generar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GTicket";
            this.Text = "GTicket";
            this.Load += new System.EventHandler(this.GTicket_Load);
            this.gpb_generar.ResumeLayout(false);
            this.gpb_generar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_generar;
        private System.Windows.Forms.Label lbl_codigocliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.ComboBox cmb_tarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora_de_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_cajon;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_corte;
        private System.Windows.Forms.Button btn_pagarticket;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fechahorasalida;
        private System.Windows.Forms.DateTimePicker dtp_fechahora_entrada;
        private System.Windows.Forms.ComboBox cmb_cajones;
        private System.Windows.Forms.TextBox txt_total_pagar;
    }
}