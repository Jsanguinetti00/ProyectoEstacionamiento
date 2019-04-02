namespace Estacionamiento.GUI
{
    partial class CajonesyT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajonesyT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cajon = new System.Windows.Forms.TextBox();
            this.txt_generarcajones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.cmb_nombreestacionamiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_cajones = new System.Windows.Forms.DataGridView();
            this.id_cajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_cajon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_Tarifa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgv_tarifa = new System.Windows.Forms.DataGridView();
            this.id_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_aplicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cajones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cajon);
            this.groupBox1.Controls.Add(this.txt_generarcajones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_estado);
            this.groupBox1.Controls.Add(this.cmb_nombreestacionamiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtg_cajones);
            this.groupBox1.Controls.Add(this.cmb_tipo);
            this.groupBox1.Controls.Add(this.btn_actualizar);
            this.groupBox1.Controls.Add(this.lbl_tipo);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.lbl_estado);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(111, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajones";
            // 
            // txt_cajon
            // 
            this.txt_cajon.Enabled = false;
            this.txt_cajon.Location = new System.Drawing.Point(174, 20);
            this.txt_cajon.Name = "txt_cajon";
            this.txt_cajon.Size = new System.Drawing.Size(39, 26);
            this.txt_cajon.TabIndex = 27;
            // 
            // txt_generarcajones
            // 
            this.txt_generarcajones.Location = new System.Drawing.Point(174, 47);
            this.txt_generarcajones.Name = "txt_generarcajones";
            this.txt_generarcajones.Size = new System.Drawing.Size(137, 26);
            this.txt_generarcajones.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Numero De Cajon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Generar No. Cajones";
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Ocupado",
            "Disponible"});
            this.cmb_estado.Location = new System.Drawing.Point(174, 82);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(137, 26);
            this.cmb_estado.TabIndex = 24;
            // 
            // cmb_nombreestacionamiento
            // 
            this.cmb_nombreestacionamiento.FormattingEnabled = true;
            this.cmb_nombreestacionamiento.Location = new System.Drawing.Point(174, 114);
            this.cmb_nombreestacionamiento.Name = "cmb_nombreestacionamiento";
            this.cmb_nombreestacionamiento.Size = new System.Drawing.Size(137, 26);
            this.cmb_nombreestacionamiento.TabIndex = 23;
            this.cmb_nombreestacionamiento.SelectedIndexChanged += new System.EventHandler(this.cmb_nombreestacionamiento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estacionamiento";
            // 
            // dtg_cajones
            // 
            this.dtg_cajones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cajones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cajon,
            this.estatus,
            this.tipo_de_cajon,
            this.nombre});
            this.dtg_cajones.Location = new System.Drawing.Point(6, 186);
            this.dtg_cajones.Name = "dtg_cajones";
            this.dtg_cajones.Size = new System.Drawing.Size(650, 107);
            this.dtg_cajones.TabIndex = 21;
            this.dtg_cajones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_cajones_CellContentClick);
            // 
            // id_cajon
            // 
            this.id_cajon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_cajon.DataPropertyName = "id_cajon";
            this.id_cajon.HeaderText = "Numero Del Cajon";
            this.id_cajon.Name = "id_cajon";
            // 
            // estatus
            // 
            this.estatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estatus.DataPropertyName = "estatus";
            this.estatus.HeaderText = "Estado Del Cajon";
            this.estatus.Name = "estatus";
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
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre del estacionamiento";
            this.nombre.Name = "nombre";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(174, 146);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(137, 26);
            this.cmb_tipo.TabIndex = 20;
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_SelectedIndexChanged);
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
            this.btn_actualizar.Location = new System.Drawing.Point(395, 75);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(166, 38);
            this.btn_actualizar.TabIndex = 19;
            this.btn_actualizar.Text = "Actualizar cajón";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(63, 154);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(105, 18);
            this.lbl_tipo.TabIndex = 17;
            this.lbl_tipo.Text = "Tipo de cajón";
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
            this.btn_eliminar.Location = new System.Drawing.Point(395, 122);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(166, 38);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar cajón";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(395, 35);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(166, 38);
            this.btn_agregar.TabIndex = 15;
            this.btn_agregar.Text = "Agregar cajón";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(110, 85);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(58, 18);
            this.lbl_estado.TabIndex = 3;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_Tarifa
            // 
            this.lbl_Tarifa.AutoSize = true;
            this.lbl_Tarifa.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Tarifa.Location = new System.Drawing.Point(211, 334);
            this.lbl_Tarifa.Name = "lbl_Tarifa";
            this.lbl_Tarifa.Size = new System.Drawing.Size(67, 18);
            this.lbl_Tarifa.TabIndex = 1;
            this.lbl_Tarifa.Text = "Id Tarifa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(132, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la tarifa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(142, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "precio de la tarifa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 402);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 6;
            // 
            // dgv_tarifa
            // 
            this.dgv_tarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tarifa,
            this.costo_tarifa,
            this.tiempo_aplicado});
            this.dgv_tarifa.Location = new System.Drawing.Point(117, 428);
            this.dgv_tarifa.Name = "dgv_tarifa";
            this.dgv_tarifa.Size = new System.Drawing.Size(650, 115);
            this.dgv_tarifa.TabIndex = 7;
            this.dgv_tarifa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tarifa_CellContentClick);
            // 
            // id_tarifa
            // 
            this.id_tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_tarifa.DataPropertyName = "id_tarifa";
            this.id_tarifa.HeaderText = "Numero De Tarifa";
            this.id_tarifa.Name = "id_tarifa";
            // 
            // costo_tarifa
            // 
            this.costo_tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costo_tarifa.DataPropertyName = "costo_tarifa";
            this.costo_tarifa.HeaderText = "Costo De La Tarifa";
            this.costo_tarifa.Name = "costo_tarifa";
            // 
            // tiempo_aplicado
            // 
            this.tiempo_aplicado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tiempo_aplicado.DataPropertyName = "tiempo_aplicado";
            this.tiempo_aplicado.HeaderText = "Nombre De La Tarifa";
            this.tiempo_aplicado.Name = "tiempo_aplicado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(522, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar Tarifa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(522, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 35);
            this.button2.TabIndex = 24;
            this.button2.Text = "Actualizar Tarifa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(522, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 28);
            this.button3.TabIndex = 25;
            this.button3.Text = "Eliminar Tarifa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // CajonesyT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 568);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_tarifa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Tarifa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CajonesyT";
            this.Text = "CajonesyT";
            this.Load += new System.EventHandler(this.CajonesyT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cajones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.DataGridView dtg_cajones;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cmb_nombreestacionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Tarifa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgv_tarifa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_generarcajones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cajon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cajon;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_cajon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_aplicado;
    }
}