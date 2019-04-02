namespace Estacionamiento.GUI
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_folio_serv = new System.Windows.Forms.TextBox();
            this.lbl_folio_serv = new System.Windows.Forms.Label();
            this.txt_pagserv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_pagser = new System.Windows.Forms.ComboBox();
            this.dtg_pagoser = new System.Windows.Forms.DataGridView();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lbl_codigocliente = new System.Windows.Forms.Label();
            this.gbp_agregarservicios = new System.Windows.Forms.GroupBox();
            this.txt_id_servicio = new System.Windows.Forms.TextBox();
            this.btn_eliminarservicio = new System.Windows.Forms.Button();
            this.btn_actualizarservicio = new System.Windows.Forms.Button();
            this.txt_nombreservicio = new System.Windows.Forms.TextBox();
            this.lbl_tiposervicio = new System.Windows.Forms.Label();
            this.dtg_tiposervicios = new System.Windows.Forms.DataGridView();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregarservicio = new System.Windows.Forms.Button();
            this.lbl_id_servicio = new System.Windows.Forms.Label();
            this.folio_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_id_corte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagoser)).BeginInit();
            this.gbp_agregarservicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tiposervicios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_folio_serv);
            this.groupBox1.Controls.Add(this.lbl_folio_serv);
            this.groupBox1.Controls.Add(this.txt_pagserv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_pagser);
            this.groupBox1.Controls.Add(this.dtg_pagoser);
            this.groupBox1.Controls.Add(this.btn_pagar);
            this.groupBox1.Controls.Add(this.lbl_codigocliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pago de servicios";
            // 
            // txt_folio_serv
            // 
            this.txt_folio_serv.Enabled = false;
            this.txt_folio_serv.Location = new System.Drawing.Point(532, 19);
            this.txt_folio_serv.Name = "txt_folio_serv";
            this.txt_folio_serv.Size = new System.Drawing.Size(120, 26);
            this.txt_folio_serv.TabIndex = 28;
            // 
            // lbl_folio_serv
            // 
            this.lbl_folio_serv.AutoSize = true;
            this.lbl_folio_serv.Location = new System.Drawing.Point(421, 22);
            this.lbl_folio_serv.Name = "lbl_folio_serv";
            this.lbl_folio_serv.Size = new System.Drawing.Size(105, 18);
            this.lbl_folio_serv.TabIndex = 25;
            this.lbl_folio_serv.Text = "Folio servicio";
            this.lbl_folio_serv.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_pagserv
            // 
            this.txt_pagserv.Location = new System.Drawing.Point(147, 93);
            this.txt_pagserv.Name = "txt_pagserv";
            this.txt_pagserv.Size = new System.Drawing.Size(120, 26);
            this.txt_pagserv.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Monto a pagar";
            // 
            // cmb_pagser
            // 
            this.cmb_pagser.FormattingEnabled = true;
            this.cmb_pagser.Location = new System.Drawing.Point(146, 55);
            this.cmb_pagser.Name = "cmb_pagser";
            this.cmb_pagser.Size = new System.Drawing.Size(121, 26);
            this.cmb_pagser.TabIndex = 22;
            this.cmb_pagser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtg_pagoser
            // 
            this.dtg_pagoser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pagoser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folio_servicio,
            this.fecha_servicio,
            this.total_pagar,
            this.fk_id_servicio,
            this.fk_id_empleado,
            this.fk_id_corte});
            this.dtg_pagoser.Location = new System.Drawing.Point(6, 154);
            this.dtg_pagoser.Name = "dtg_pagoser";
            this.dtg_pagoser.Size = new System.Drawing.Size(650, 130);
            this.dtg_pagoser.TabIndex = 21;
            this.dtg_pagoser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_pagoser_CellContentClick);
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
            this.btn_pagar.Location = new System.Drawing.Point(296, 58);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(145, 38);
            this.btn_pagar.TabIndex = 15;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // lbl_codigocliente
            // 
            this.lbl_codigocliente.AutoSize = true;
            this.lbl_codigocliente.Location = new System.Drawing.Point(73, 58);
            this.lbl_codigocliente.Name = "lbl_codigocliente";
            this.lbl_codigocliente.Size = new System.Drawing.Size(67, 18);
            this.lbl_codigocliente.TabIndex = 1;
            this.lbl_codigocliente.Text = "Servicio";
            // 
            // gbp_agregarservicios
            // 
            this.gbp_agregarservicios.Controls.Add(this.txt_id_servicio);
            this.gbp_agregarservicios.Controls.Add(this.btn_eliminarservicio);
            this.gbp_agregarservicios.Controls.Add(this.btn_actualizarservicio);
            this.gbp_agregarservicios.Controls.Add(this.txt_nombreservicio);
            this.gbp_agregarservicios.Controls.Add(this.lbl_tiposervicio);
            this.gbp_agregarservicios.Controls.Add(this.dtg_tiposervicios);
            this.gbp_agregarservicios.Controls.Add(this.btn_agregarservicio);
            this.gbp_agregarservicios.Controls.Add(this.lbl_id_servicio);
            this.gbp_agregarservicios.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_agregarservicios.Location = new System.Drawing.Point(69, 308);
            this.gbp_agregarservicios.Name = "gbp_agregarservicios";
            this.gbp_agregarservicios.Size = new System.Drawing.Size(662, 283);
            this.gbp_agregarservicios.TabIndex = 4;
            this.gbp_agregarservicios.TabStop = false;
            this.gbp_agregarservicios.Text = "Agregar servicios";
            // 
            // txt_id_servicio
            // 
            this.txt_id_servicio.Enabled = false;
            this.txt_id_servicio.Location = new System.Drawing.Point(159, 45);
            this.txt_id_servicio.Name = "txt_id_servicio";
            this.txt_id_servicio.Size = new System.Drawing.Size(120, 26);
            this.txt_id_servicio.TabIndex = 27;
            this.txt_id_servicio.TextChanged += new System.EventHandler(this.txt_id_servicio_TextChanged);
            // 
            // btn_eliminarservicio
            // 
            this.btn_eliminarservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_eliminarservicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminarservicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminarservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarservicio.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarservicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarservicio.Location = new System.Drawing.Point(313, 83);
            this.btn_eliminarservicio.Name = "btn_eliminarservicio";
            this.btn_eliminarservicio.Size = new System.Drawing.Size(164, 32);
            this.btn_eliminarservicio.TabIndex = 26;
            this.btn_eliminarservicio.Text = "eliminar servicio";
            this.btn_eliminarservicio.UseVisualStyleBackColor = false;
            this.btn_eliminarservicio.Click += new System.EventHandler(this.btn_eliminarservicio_Click);
            // 
            // btn_actualizarservicio
            // 
            this.btn_actualizarservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_actualizarservicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizarservicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizarservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarservicio.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarservicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizarservicio.Location = new System.Drawing.Point(313, 49);
            this.btn_actualizarservicio.Name = "btn_actualizarservicio";
            this.btn_actualizarservicio.Size = new System.Drawing.Size(164, 27);
            this.btn_actualizarservicio.TabIndex = 25;
            this.btn_actualizarservicio.Text = "actualizar servicio";
            this.btn_actualizarservicio.UseVisualStyleBackColor = false;
            this.btn_actualizarservicio.Click += new System.EventHandler(this.btn_actualizarservicio_Click);
            // 
            // txt_nombreservicio
            // 
            this.txt_nombreservicio.Location = new System.Drawing.Point(159, 80);
            this.txt_nombreservicio.Name = "txt_nombreservicio";
            this.txt_nombreservicio.Size = new System.Drawing.Size(120, 26);
            this.txt_nombreservicio.TabIndex = 24;
            // 
            // lbl_tiposervicio
            // 
            this.lbl_tiposervicio.AutoSize = true;
            this.lbl_tiposervicio.Location = new System.Drawing.Point(6, 83);
            this.lbl_tiposervicio.Name = "lbl_tiposervicio";
            this.lbl_tiposervicio.Size = new System.Drawing.Size(147, 18);
            this.lbl_tiposervicio.TabIndex = 23;
            this.lbl_tiposervicio.Text = "nombre de servicio";
            // 
            // dtg_tiposervicios
            // 
            this.dtg_tiposervicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_tiposervicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servicio,
            this.tipo_servicio});
            this.dtg_tiposervicios.Location = new System.Drawing.Point(6, 154);
            this.dtg_tiposervicios.Name = "dtg_tiposervicios";
            this.dtg_tiposervicios.Size = new System.Drawing.Size(650, 114);
            this.dtg_tiposervicios.TabIndex = 21;
            this.dtg_tiposervicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_tiposervicios_CellContentClick);
            this.dtg_tiposervicios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_tiposervicios_CellMouseClick);
            // 
            // id_servicio
            // 
            this.id_servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_servicio.DataPropertyName = "id_servicio";
            this.id_servicio.HeaderText = "Id Servicio";
            this.id_servicio.Name = "id_servicio";
            // 
            // tipo_servicio
            // 
            this.tipo_servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_servicio.DataPropertyName = "tipo_servicio";
            this.tipo_servicio.HeaderText = "servicio";
            this.tipo_servicio.Name = "tipo_servicio";
            // 
            // btn_agregarservicio
            // 
            this.btn_agregarservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_agregarservicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_agregarservicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregarservicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarservicio.ForeColor = System.Drawing.Color.White;
            this.btn_agregarservicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarservicio.Location = new System.Drawing.Point(313, 16);
            this.btn_agregarservicio.Name = "btn_agregarservicio";
            this.btn_agregarservicio.Size = new System.Drawing.Size(164, 27);
            this.btn_agregarservicio.TabIndex = 15;
            this.btn_agregarservicio.Text = "agregar servicio";
            this.btn_agregarservicio.UseVisualStyleBackColor = false;
            this.btn_agregarservicio.Click += new System.EventHandler(this.btn_agregarservicio_Click);
            // 
            // lbl_id_servicio
            // 
            this.lbl_id_servicio.AutoSize = true;
            this.lbl_id_servicio.Location = new System.Drawing.Point(50, 45);
            this.lbl_id_servicio.Name = "lbl_id_servicio";
            this.lbl_id_servicio.Size = new System.Drawing.Size(85, 18);
            this.lbl_id_servicio.TabIndex = 1;
            this.lbl_id_servicio.Text = "Id Servicio";
            // 
            // folio_servicio
            // 
            this.folio_servicio.DataPropertyName = "folio_servicio";
            this.folio_servicio.HeaderText = "Folio del pago ";
            this.folio_servicio.Name = "folio_servicio";
            // 
            // fecha_servicio
            // 
            this.fecha_servicio.DataPropertyName = "fecha_servicio";
            this.fecha_servicio.HeaderText = "Fecha del pago";
            this.fecha_servicio.Name = "fecha_servicio";
            // 
            // total_pagar
            // 
            this.total_pagar.DataPropertyName = "total_pago";
            this.total_pagar.HeaderText = "Total del pago";
            this.total_pagar.Name = "total_pagar";
            // 
            // fk_id_servicio
            // 
            this.fk_id_servicio.DataPropertyName = "id_servicio";
            this.fk_id_servicio.HeaderText = "Id del servicio";
            this.fk_id_servicio.Name = "fk_id_servicio";
            // 
            // fk_id_empleado
            // 
            this.fk_id_empleado.DataPropertyName = "id_empleado";
            this.fk_id_empleado.HeaderText = "Id del empleado";
            this.fk_id_empleado.Name = "fk_id_empleado";
            // 
            // fk_id_corte
            // 
            this.fk_id_corte.DataPropertyName = "id_corte";
            this.fk_id_corte.HeaderText = "Id del corte";
            this.fk_id_corte.Name = "fk_id_corte";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.gbp_agregarservicios);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pagoser)).EndInit();
            this.gbp_agregarservicios.ResumeLayout(false);
            this.gbp_agregarservicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tiposervicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pagserv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_pagser;
        private System.Windows.Forms.DataGridView dtg_pagoser;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_codigocliente;
        private System.Windows.Forms.GroupBox gbp_agregarservicios;
        private System.Windows.Forms.TextBox txt_id_servicio;
        private System.Windows.Forms.Button btn_eliminarservicio;
        private System.Windows.Forms.Button btn_actualizarservicio;
        private System.Windows.Forms.TextBox txt_nombreservicio;
        private System.Windows.Forms.Label lbl_tiposervicio;
        private System.Windows.Forms.DataGridView dtg_tiposervicios;
        private System.Windows.Forms.Button btn_agregarservicio;
        private System.Windows.Forms.Label lbl_id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_servicio;
        private System.Windows.Forms.Label lbl_folio_serv;
        private System.Windows.Forms.TextBox txt_folio_serv;
        private System.Windows.Forms.DataGridViewTextBoxColumn folio_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_id_corte;
    }
}