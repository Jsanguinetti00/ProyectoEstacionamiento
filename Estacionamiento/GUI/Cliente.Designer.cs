namespace Estacionamiento.GUI
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.gpb_info_g = new System.Windows.Forms.GroupBox();
            this.btn_agregarvehiculo = new System.Windows.Forms.Button();
            this.cmb_tarifa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_apellidomat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellidopat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_codigocliente = new System.Windows.Forms.TextBox();
            this.lbl_codigocliente = new System.Windows.Forms.Label();
            this.dgv_informaciongral = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_aplicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.gpb_info_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informaciongral)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_info_g
            // 
            this.gpb_info_g.BackColor = System.Drawing.Color.Transparent;
            this.gpb_info_g.Controls.Add(this.btn_agregarvehiculo);
            this.gpb_info_g.Controls.Add(this.cmb_tarifa);
            this.gpb_info_g.Controls.Add(this.label2);
            this.gpb_info_g.Controls.Add(this.txt_direccion);
            this.gpb_info_g.Controls.Add(this.label14);
            this.gpb_info_g.Controls.Add(this.txt_apellidomat);
            this.gpb_info_g.Controls.Add(this.label1);
            this.gpb_info_g.Controls.Add(this.txt_apellidopat);
            this.gpb_info_g.Controls.Add(this.label10);
            this.gpb_info_g.Controls.Add(this.btn_limpiar);
            this.gpb_info_g.Controls.Add(this.btn_eliminar);
            this.gpb_info_g.Controls.Add(this.txt_telefono);
            this.gpb_info_g.Controls.Add(this.label13);
            this.gpb_info_g.Controls.Add(this.btn_actualizar);
            this.gpb_info_g.Controls.Add(this.txt_edad);
            this.gpb_info_g.Controls.Add(this.btn_guardar);
            this.gpb_info_g.Controls.Add(this.label12);
            this.gpb_info_g.Controls.Add(this.txt_nombres);
            this.gpb_info_g.Controls.Add(this.label9);
            this.gpb_info_g.Controls.Add(this.txt_codigocliente);
            this.gpb_info_g.Controls.Add(this.lbl_codigocliente);
            this.gpb_info_g.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.gpb_info_g.Location = new System.Drawing.Point(74, 23);
            this.gpb_info_g.Name = "gpb_info_g";
            this.gpb_info_g.Size = new System.Drawing.Size(730, 280);
            this.gpb_info_g.TabIndex = 1;
            this.gpb_info_g.TabStop = false;
            this.gpb_info_g.Text = "Información genral";
            // 
            // btn_agregarvehiculo
            // 
            this.btn_agregarvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_agregarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_agregarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarvehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_agregarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarvehiculo.Location = new System.Drawing.Point(562, 218);
            this.btn_agregarvehiculo.Name = "btn_agregarvehiculo";
            this.btn_agregarvehiculo.Size = new System.Drawing.Size(123, 56);
            this.btn_agregarvehiculo.TabIndex = 28;
            this.btn_agregarvehiculo.Text = "agregar vehiculo";
            this.btn_agregarvehiculo.UseVisualStyleBackColor = false;
            this.btn_agregarvehiculo.Click += new System.EventHandler(this.btn_agregarvehiculo_Click);
            // 
            // cmb_tarifa
            // 
            this.cmb_tarifa.FormattingEnabled = true;
            this.cmb_tarifa.Location = new System.Drawing.Point(158, 244);
            this.cmb_tarifa.Name = "cmb_tarifa";
            this.cmb_tarifa.Size = new System.Drawing.Size(370, 26);
            this.cmb_tarifa.TabIndex = 27;
            this.cmb_tarifa.SelectedIndexChanged += new System.EventHandler(this.cmb_tarifa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tarifa";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_direccion.Location = new System.Drawing.Point(158, 217);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(370, 23);
            this.txt_direccion.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "Dirección";
            // 
            // txt_apellidomat
            // 
            this.txt_apellidomat.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_apellidomat.Location = new System.Drawing.Point(158, 151);
            this.txt_apellidomat.Name = "txt_apellidomat";
            this.txt_apellidomat.Size = new System.Drawing.Size(308, 23);
            this.txt_apellidomat.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Apellido Materno";
            // 
            // txt_apellidopat
            // 
            this.txt_apellidopat.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_apellidopat.Location = new System.Drawing.Point(158, 112);
            this.txt_apellidopat.Name = "txt_apellidopat";
            this.txt_apellidopat.Size = new System.Drawing.Size(308, 23);
            this.txt_apellidopat.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Apellido Paterno";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(562, 171);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(123, 38);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(562, 127);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 38);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_telefono.Location = new System.Drawing.Point(292, 186);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(233, 23);
            this.txt_telefono.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Teléfono";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(562, 83);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(123, 38);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_edad.Location = new System.Drawing.Point(158, 186);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(49, 23);
            this.txt_edad.TabIndex = 9;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(562, 39);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 38);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 19);
            this.label12.TabIndex = 8;
            this.label12.Text = "Edad";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_nombres.Location = new System.Drawing.Point(158, 74);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(367, 23);
            this.txt_nombres.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombres";
            // 
            // txt_codigocliente
            // 
            this.txt_codigocliente.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_codigocliente.Location = new System.Drawing.Point(158, 35);
            this.txt_codigocliente.Name = "txt_codigocliente";
            this.txt_codigocliente.Size = new System.Drawing.Size(65, 23);
            this.txt_codigocliente.TabIndex = 1;
            // 
            // lbl_codigocliente
            // 
            this.lbl_codigocliente.AutoSize = true;
            this.lbl_codigocliente.Location = new System.Drawing.Point(6, 39);
            this.lbl_codigocliente.Name = "lbl_codigocliente";
            this.lbl_codigocliente.Size = new System.Drawing.Size(146, 19);
            this.lbl_codigocliente.TabIndex = 0;
            this.lbl_codigocliente.Text = "Código del cliente";
            // 
            // dgv_informaciongral
            // 
            this.dgv_informaciongral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_informaciongral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre,
            this.apellido_paterno,
            this.aellido_materno,
            this.telefono,
            this.edad,
            this.direccion,
            this.id_tarifa,
            this.costo_tarifa,
            this.tiempo_aplicado});
            this.dgv_informaciongral.Location = new System.Drawing.Point(74, 344);
            this.dgv_informaciongral.Name = "dgv_informaciongral";
            this.dgv_informaciongral.Size = new System.Drawing.Size(730, 282);
            this.dgv_informaciongral.TabIndex = 2;
            this.dgv_informaciongral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_informaciongral_CellContentClick);
            this.dgv_informaciongral.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_informaciongral_CellMouseClick);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "Numero De Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "Apellido paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // aellido_materno
            // 
            this.aellido_materno.DataPropertyName = "aellido_materno";
            this.aellido_materno.HeaderText = "Apellido Materno";
            this.aellido_materno.Name = "aellido_materno";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.Name = "telefono";
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "edad";
            this.edad.Name = "edad";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // id_tarifa
            // 
            this.id_tarifa.DataPropertyName = "id_tarifa";
            this.id_tarifa.HeaderText = "Id Tarifa";
            this.id_tarifa.Name = "id_tarifa";
            this.id_tarifa.Visible = false;
            // 
            // costo_tarifa
            // 
            this.costo_tarifa.DataPropertyName = "costo_tarifa";
            this.costo_tarifa.HeaderText = "Costo de Tarifa";
            this.costo_tarifa.Name = "costo_tarifa";
            // 
            // tiempo_aplicado
            // 
            this.tiempo_aplicado.DataPropertyName = "tiempo_aplicado";
            this.tiempo_aplicado.HeaderText = "Tipo de Tarifa";
            this.tiempo_aplicado.Name = "tiempo_aplicado";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_buscar.Location = new System.Drawing.Point(232, 305);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(367, 23);
            this.txt_buscar.TabIndex = 11;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar.Location = new System.Drawing.Point(164, 306);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 19);
            this.lbl_buscar.TabIndex = 10;
            this.lbl_buscar.Text = "Buscar";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 638);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dgv_informaciongral);
            this.Controls.Add(this.gpb_info_g);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gpb_info_g.ResumeLayout(false);
            this.gpb_info_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_informaciongral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_info_g;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_codigocliente;
        private System.Windows.Forms.Label lbl_codigocliente;
        private System.Windows.Forms.DataGridView dgv_informaciongral;
        private System.Windows.Forms.ComboBox cmb_tarifa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_apellidomat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellidopat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_aplicado;
        private System.Windows.Forms.Button btn_agregarvehiculo;
    }
}