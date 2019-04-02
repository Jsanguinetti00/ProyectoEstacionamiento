namespace Estacionamiento.GUI
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.gpb_info_g = new System.Windows.Forms.GroupBox();
            this.cmb_turno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.cmb_empresa = new System.Windows.Forms.ComboBox();
            this.lbl_tipocuenta = new System.Windows.Forms.Label();
            this.txt_apellidomat = new System.Windows.Forms.TextBox();
            this.lbl_apellidomat = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.txt_apellidopat = new System.Windows.Forms.TextBox();
            this.lbl_apellidopat = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.lbl_codigoempleado = new System.Windows.Forms.Label();
            this.btn_añadirusuario = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.dgv_empleado = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_tipocuenta = new System.Windows.Forms.ComboBox();
            this.txt_fk_id_emple = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminarus = new System.Windows.Forms.Button();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_editarus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_confcontra = new System.Windows.Forms.TextBox();
            this.btn_veremple = new System.Windows.Forms.Button();
            this.btn_verusu = new System.Windows.Forms.Button();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.gpb_info_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_info_g
            // 
            this.gpb_info_g.BackColor = System.Drawing.Color.Transparent;
            this.gpb_info_g.Controls.Add(this.cmb_turno);
            this.gpb_info_g.Controls.Add(this.label2);
            this.gpb_info_g.Controls.Add(this.txt_curp);
            this.gpb_info_g.Controls.Add(this.label1);
            this.gpb_info_g.Controls.Add(this.txt_direccion);
            this.gpb_info_g.Controls.Add(this.lbl_direccion);
            this.gpb_info_g.Controls.Add(this.cmb_empresa);
            this.gpb_info_g.Controls.Add(this.lbl_tipocuenta);
            this.gpb_info_g.Controls.Add(this.txt_apellidomat);
            this.gpb_info_g.Controls.Add(this.lbl_apellidomat);
            this.gpb_info_g.Controls.Add(this.btn_limpiar);
            this.gpb_info_g.Controls.Add(this.btn_eliminar);
            this.gpb_info_g.Controls.Add(this.txt_telefono);
            this.gpb_info_g.Controls.Add(this.lbl_telefono);
            this.gpb_info_g.Controls.Add(this.btn_actualizar);
            this.gpb_info_g.Controls.Add(this.txt_edad);
            this.gpb_info_g.Controls.Add(this.btn_guardar);
            this.gpb_info_g.Controls.Add(this.lbl_edad);
            this.gpb_info_g.Controls.Add(this.txt_apellidopat);
            this.gpb_info_g.Controls.Add(this.lbl_apellidopat);
            this.gpb_info_g.Controls.Add(this.txt_nombres);
            this.gpb_info_g.Controls.Add(this.lbl_nombres);
            this.gpb_info_g.Controls.Add(this.txt_id_empleado);
            this.gpb_info_g.Controls.Add(this.lbl_codigoempleado);
            this.gpb_info_g.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.gpb_info_g.Location = new System.Drawing.Point(111, 12);
            this.gpb_info_g.Name = "gpb_info_g";
            this.gpb_info_g.Size = new System.Drawing.Size(739, 260);
            this.gpb_info_g.TabIndex = 2;
            this.gpb_info_g.TabStop = false;
            this.gpb_info_g.Text = "Información genral";
            this.gpb_info_g.Enter += new System.EventHandler(this.gpb_info_g_Enter);
            // 
            // cmb_turno
            // 
            this.cmb_turno.FormattingEnabled = true;
            this.cmb_turno.Location = new System.Drawing.Point(418, 100);
            this.cmb_turno.Name = "cmb_turno";
            this.cmb_turno.Size = new System.Drawing.Size(128, 26);
            this.cmb_turno.TabIndex = 29;
            this.cmb_turno.Text = "Selecciona";
            this.cmb_turno.SelectedIndexChanged += new System.EventHandler(this.cmb_turno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Turno";
            // 
            // txt_curp
            // 
            this.txt_curp.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_curp.Location = new System.Drawing.Point(179, 164);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(367, 23);
            this.txt_curp.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Curp";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_direccion.Location = new System.Drawing.Point(179, 192);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(367, 23);
            this.txt_direccion.TabIndex = 25;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(92, 196);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(81, 19);
            this.lbl_direccion.TabIndex = 24;
            this.lbl_direccion.Text = "Direccion";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.FormattingEnabled = true;
            this.cmb_empresa.Location = new System.Drawing.Point(433, 61);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Size = new System.Drawing.Size(114, 26);
            this.cmb_empresa.TabIndex = 23;
            this.cmb_empresa.Text = "Selecciona";
            this.cmb_empresa.SelectedIndexChanged += new System.EventHandler(this.cmb_tipocuenta_SelectedIndexChanged);
            // 
            // lbl_tipocuenta
            // 
            this.lbl_tipocuenta.AutoSize = true;
            this.lbl_tipocuenta.Location = new System.Drawing.Point(352, 64);
            this.lbl_tipocuenta.Name = "lbl_tipocuenta";
            this.lbl_tipocuenta.Size = new System.Drawing.Size(75, 19);
            this.lbl_tipocuenta.TabIndex = 22;
            this.lbl_tipocuenta.Text = "Empresa";
            // 
            // txt_apellidomat
            // 
            this.txt_apellidomat.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_apellidomat.Location = new System.Drawing.Point(179, 135);
            this.txt_apellidomat.Name = "txt_apellidomat";
            this.txt_apellidomat.Size = new System.Drawing.Size(367, 23);
            this.txt_apellidomat.TabIndex = 21;
            // 
            // lbl_apellidomat
            // 
            this.lbl_apellidomat.AutoSize = true;
            this.lbl_apellidomat.Location = new System.Drawing.Point(34, 136);
            this.lbl_apellidomat.Name = "lbl_apellidomat";
            this.lbl_apellidomat.Size = new System.Drawing.Size(139, 19);
            this.lbl_apellidomat.TabIndex = 20;
            this.lbl_apellidomat.Text = "Apellido materno";
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
            this.btn_limpiar.Location = new System.Drawing.Point(596, 171);
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
            this.btn_eliminar.Location = new System.Drawing.Point(596, 127);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(123, 38);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_telefono.Location = new System.Drawing.Point(314, 225);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(233, 23);
            this.txt_telefono.TabIndex = 11;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(235, 226);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(73, 19);
            this.lbl_telefono.TabIndex = 10;
            this.lbl_telefono.Text = "Teléfono";
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
            this.btn_actualizar.Location = new System.Drawing.Point(596, 83);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(123, 38);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_edad.Location = new System.Drawing.Point(180, 225);
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
            this.btn_guardar.Location = new System.Drawing.Point(596, 39);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 38);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(128, 226);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(46, 19);
            this.lbl_edad.TabIndex = 8;
            this.lbl_edad.Text = "Edad";
            // 
            // txt_apellidopat
            // 
            this.txt_apellidopat.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_apellidopat.Location = new System.Drawing.Point(179, 102);
            this.txt_apellidopat.Name = "txt_apellidopat";
            this.txt_apellidopat.Size = new System.Drawing.Size(170, 23);
            this.txt_apellidopat.TabIndex = 5;
            // 
            // lbl_apellidopat
            // 
            this.lbl_apellidopat.AutoSize = true;
            this.lbl_apellidopat.Location = new System.Drawing.Point(39, 103);
            this.lbl_apellidopat.Name = "lbl_apellidopat";
            this.lbl_apellidopat.Size = new System.Drawing.Size(134, 19);
            this.lbl_apellidopat.TabIndex = 4;
            this.lbl_apellidopat.Text = "Apellido paterno";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_nombres.Location = new System.Drawing.Point(179, 64);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(170, 23);
            this.txt_nombres.TabIndex = 3;
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(96, 68);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(77, 19);
            this.lbl_nombres.TabIndex = 2;
            this.lbl_nombres.Text = "Nombres";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_id_empleado.Location = new System.Drawing.Point(179, 35);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(65, 23);
            this.txt_id_empleado.TabIndex = 1;
            // 
            // lbl_codigoempleado
            // 
            this.lbl_codigoempleado.AutoSize = true;
            this.lbl_codigoempleado.Location = new System.Drawing.Point(6, 36);
            this.lbl_codigoempleado.Name = "lbl_codigoempleado";
            this.lbl_codigoempleado.Size = new System.Drawing.Size(167, 19);
            this.lbl_codigoempleado.TabIndex = 0;
            this.lbl_codigoempleado.Text = "Código del empleado";
            // 
            // btn_añadirusuario
            // 
            this.btn_añadirusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_añadirusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_añadirusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_añadirusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadirusuario.ForeColor = System.Drawing.Color.White;
            this.btn_añadirusuario.Location = new System.Drawing.Point(566, 16);
            this.btn_añadirusuario.Name = "btn_añadirusuario";
            this.btn_añadirusuario.Size = new System.Drawing.Size(153, 27);
            this.btn_añadirusuario.TabIndex = 30;
            this.btn_añadirusuario.Text = "Añadir usuario";
            this.btn_añadirusuario.UseVisualStyleBackColor = false;
            this.btn_añadirusuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_contraseña.Location = new System.Drawing.Point(180, 78);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(366, 23);
            this.txt_contraseña.TabIndex = 19;
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(79, 82);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(95, 19);
            this.lbl_contraseña.TabIndex = 18;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.Location = new System.Drawing.Point(180, 49);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(366, 23);
            this.txt_usuario.TabIndex = 13;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(106, 54);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(68, 19);
            this.lbl_usuario.TabIndex = 12;
            this.lbl_usuario.Text = "Usuario";
            // 
            // dgv_empleado
            // 
            this.dgv_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.Curp,
            this.Nombre,
            this.apellido_paterno,
            this.apellido_materno,
            this.edad,
            this.direccion,
            this.telefono_empleado,
            this.nombre_empresa,
            this.tipo_turno});
            this.dgv_empleado.Location = new System.Drawing.Point(111, 449);
            this.dgv_empleado.Name = "dgv_empleado";
            this.dgv_empleado.Size = new System.Drawing.Size(739, 182);
            this.dgv_empleado.TabIndex = 3;
            this.dgv_empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empleado_CellContentClick);
            this.dgv_empleado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_empleado_CellMouseClick);
            // 
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "codigo empleado";
            this.id_empleado.Name = "id_empleado";
            // 
            // Curp
            // 
            this.Curp.DataPropertyName = "curp";
            this.Curp.HeaderText = "curp";
            this.Curp.Name = "Curp";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "nombre";
            this.Nombre.Name = "Nombre";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "Apellido Paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // apellido_materno
            // 
            this.apellido_materno.DataPropertyName = "apellido_materno";
            this.apellido_materno.HeaderText = "ApellidoMaterno";
            this.apellido_materno.Name = "apellido_materno";
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // telefono_empleado
            // 
            this.telefono_empleado.DataPropertyName = "telefono_empleado";
            this.telefono_empleado.HeaderText = "Telefono";
            this.telefono_empleado.Name = "telefono_empleado";
            // 
            // nombre_empresa
            // 
            this.nombre_empresa.DataPropertyName = "nombre_empresa";
            this.nombre_empresa.HeaderText = "empresa";
            this.nombre_empresa.Name = "nombre_empresa";
            // 
            // tipo_turno
            // 
            this.tipo_turno.DataPropertyName = "tipo_turno";
            this.tipo_turno.HeaderText = "turno";
            this.tipo_turno.Name = "tipo_turno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_tipocuenta);
            this.groupBox1.Controls.Add(this.txt_fk_id_emple);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_eliminarus);
            this.groupBox1.Controls.Add(this.lbl_codigo);
            this.groupBox1.Controls.Add(this.btn_editarus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_confcontra);
            this.groupBox1.Controls.Add(this.btn_añadirusuario);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.lbl_usuario);
            this.groupBox1.Controls.Add(this.lbl_contraseña);
            this.groupBox1.Controls.Add(this.txt_contraseña);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(111, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 137);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar usuario";
            // 
            // cmb_tipocuenta
            // 
            this.cmb_tipocuenta.FormattingEnabled = true;
            this.cmb_tipocuenta.Location = new System.Drawing.Point(392, 21);
            this.cmb_tipocuenta.Name = "cmb_tipocuenta";
            this.cmb_tipocuenta.Size = new System.Drawing.Size(154, 26);
            this.cmb_tipocuenta.TabIndex = 31;
            this.cmb_tipocuenta.Text = "Selecciona";
            this.cmb_tipocuenta.SelectedIndexChanged += new System.EventHandler(this.cmb_tipocuenta_SelectedIndexChanged_1);
            // 
            // txt_fk_id_emple
            // 
            this.txt_fk_id_emple.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_fk_id_emple.Location = new System.Drawing.Point(180, 23);
            this.txt_fk_id_emple.Name = "txt_fk_id_emple";
            this.txt_fk_id_emple.Size = new System.Drawing.Size(64, 23);
            this.txt_fk_id_emple.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo De Cuenta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_eliminarus
            // 
            this.btn_eliminarus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_eliminarus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminarus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminarus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarus.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarus.Location = new System.Drawing.Point(566, 81);
            this.btn_eliminarus.Name = "btn_eliminarus";
            this.btn_eliminarus.Size = new System.Drawing.Size(153, 27);
            this.btn_eliminarus.TabIndex = 34;
            this.btn_eliminarus.Text = "Eliminar usuario";
            this.btn_eliminarus.UseVisualStyleBackColor = false;
            this.btn_eliminarus.Click += new System.EventHandler(this.btn_eliminarus_Click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(7, 24);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(167, 19);
            this.lbl_codigo.TabIndex = 30;
            this.lbl_codigo.Text = "Código del empleado";
            // 
            // btn_editarus
            // 
            this.btn_editarus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_editarus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editarus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editarus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarus.ForeColor = System.Drawing.Color.White;
            this.btn_editarus.Location = new System.Drawing.Point(566, 49);
            this.btn_editarus.Name = "btn_editarus";
            this.btn_editarus.Size = new System.Drawing.Size(153, 27);
            this.btn_editarus.TabIndex = 33;
            this.btn_editarus.Text = "Editar usuario";
            this.btn_editarus.UseVisualStyleBackColor = false;
            this.btn_editarus.Click += new System.EventHandler(this.btn_editarus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txt_confcontra
            // 
            this.txt_confcontra.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.txt_confcontra.Location = new System.Drawing.Point(182, 107);
            this.txt_confcontra.Name = "txt_confcontra";
            this.txt_confcontra.Size = new System.Drawing.Size(364, 23);
            this.txt_confcontra.TabIndex = 31;
            // 
            // btn_veremple
            // 
            this.btn_veremple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_veremple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_veremple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_veremple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veremple.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btn_veremple.ForeColor = System.Drawing.Color.White;
            this.btn_veremple.Location = new System.Drawing.Point(505, 414);
            this.btn_veremple.Name = "btn_veremple";
            this.btn_veremple.Size = new System.Drawing.Size(153, 27);
            this.btn_veremple.TabIndex = 32;
            this.btn_veremple.Text = "ver empleados";
            this.btn_veremple.UseVisualStyleBackColor = false;
            this.btn_veremple.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_verusu
            // 
            this.btn_verusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_verusu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_verusu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_verusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verusu.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btn_verusu.ForeColor = System.Drawing.Color.White;
            this.btn_verusu.Location = new System.Drawing.Point(664, 416);
            this.btn_verusu.Name = "btn_verusu";
            this.btn_verusu.Size = new System.Drawing.Size(153, 27);
            this.btn_verusu.TabIndex = 33;
            this.btn_verusu.Text = "ver usuario";
            this.btn_verusu.UseVisualStyleBackColor = false;
            this.btn_verusu.Click += new System.EventHandler(this.btn_verusu_Click);
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Location = new System.Drawing.Point(111, 449);
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.Size = new System.Drawing.Size(739, 182);
            this.dgv_Usuario.TabIndex = 34;
            this.dgv_Usuario.Visible = false;
            this.dgv_Usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuario_CellContentClick);
            this.dgv_Usuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Usuario_CellMouseClick);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 643);
            this.Controls.Add(this.btn_verusu);
            this.Controls.Add(this.btn_veremple);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_empleado);
            this.Controls.Add(this.gpb_info_g);
            this.Controls.Add(this.dgv_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.gpb_info_g.ResumeLayout(false);
            this.gpb_info_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_info_g;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox txt_apellidopat;
        private System.Windows.Forms.Label lbl_apellidopat;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label lbl_codigoempleado;
        private System.Windows.Forms.DataGridView dgv_empleado;
        private System.Windows.Forms.TextBox txt_apellidomat;
        private System.Windows.Forms.Label lbl_apellidomat;
        private System.Windows.Forms.ComboBox cmb_empresa;
        private System.Windows.Forms.Label lbl_tipocuenta;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_turno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Button btn_añadirusuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_editarus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_confcontra;
        private System.Windows.Forms.Button btn_eliminarus;
        private System.Windows.Forms.TextBox txt_fk_id_emple;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.ComboBox cmb_tipocuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_veremple;
        private System.Windows.Forms.Button btn_verusu;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_turno;
    }
}