namespace Estacionamiento
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_realizar_c = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_config = new System.Windows.Forms.Panel();
            this.btn_turnos = new System.Windows.Forms.Button();
            this.btn_cajones = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.btn_servicios = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.btn_ticket_p = new System.Windows.Forms.Button();
            this.btn_generar_rep = new System.Windows.Forms.Button();
            this.btn_genrar_con = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_genrar_t = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbl_soft = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.pnl_inicio = new System.Windows.Forms.Panel();
            this.tmr_abrirm = new System.Windows.Forms.Timer(this.components);
            this.tmr_ocultarm = new System.Windows.Forms.Timer(this.components);
            this.tmr_abrirop = new System.Windows.Forms.Timer(this.components);
            this.tmr_ocultarop = new System.Windows.Forms.Timer(this.components);
            this.tmr_abrir_frm = new System.Windows.Forms.Timer(this.components);
            this.pnl_menu.SuspendLayout();
            this.pnl_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_menu.Controls.Add(this.btn_realizar_c);
            this.pnl_menu.Controls.Add(this.button2);
            this.pnl_menu.Controls.Add(this.pnl_config);
            this.pnl_menu.Controls.Add(this.btn_configuracion);
            this.pnl_menu.Controls.Add(this.btn_servicios);
            this.pnl_menu.Controls.Add(this.btn_switch);
            this.pnl_menu.Controls.Add(this.btn_ticket_p);
            this.pnl_menu.Controls.Add(this.btn_generar_rep);
            this.pnl_menu.Controls.Add(this.btn_genrar_con);
            this.pnl_menu.Controls.Add(this.btn_cliente);
            this.pnl_menu.Controls.Add(this.btn_genrar_t);
            this.pnl_menu.Controls.Add(this.btn_inicio);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 670);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_realizar_c
            // 
            this.btn_realizar_c.FlatAppearance.BorderSize = 0;
            this.btn_realizar_c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_realizar_c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_realizar_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_realizar_c.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_realizar_c.ForeColor = System.Drawing.Color.White;
            this.btn_realizar_c.Image = ((System.Drawing.Image)(resources.GetObject("btn_realizar_c.Image")));
            this.btn_realizar_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_realizar_c.Location = new System.Drawing.Point(0, 373);
            this.btn_realizar_c.Name = "btn_realizar_c";
            this.btn_realizar_c.Size = new System.Drawing.Size(200, 40);
            this.btn_realizar_c.TabIndex = 19;
            this.btn_realizar_c.Text = "Realizar corte";
            this.btn_realizar_c.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_realizar_c.UseVisualStyleBackColor = true;
            this.btn_realizar_c.Click += new System.EventHandler(this.btn_realizar_c_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cerrar sesión";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnl_config
            // 
            this.pnl_config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(69)))), ((int)(((byte)(152)))));
            this.pnl_config.Controls.Add(this.btn_turnos);
            this.pnl_config.Controls.Add(this.btn_cajones);
            this.pnl_config.Controls.Add(this.btn_empleados);
            this.pnl_config.Location = new System.Drawing.Point(0, 465);
            this.pnl_config.Name = "pnl_config";
            this.pnl_config.Size = new System.Drawing.Size(200, 140);
            this.pnl_config.TabIndex = 17;
            // 
            // btn_turnos
            // 
            this.btn_turnos.FlatAppearance.BorderSize = 0;
            this.btn_turnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_turnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_turnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_turnos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_turnos.ForeColor = System.Drawing.Color.White;
            this.btn_turnos.Image = ((System.Drawing.Image)(resources.GetObject("btn_turnos.Image")));
            this.btn_turnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_turnos.Location = new System.Drawing.Point(0, 95);
            this.btn_turnos.Name = "btn_turnos";
            this.btn_turnos.Size = new System.Drawing.Size(200, 40);
            this.btn_turnos.TabIndex = 18;
            this.btn_turnos.Text = "Turnos";
            this.btn_turnos.UseVisualStyleBackColor = true;
            this.btn_turnos.Click += new System.EventHandler(this.btn_turnos_Click);
            // 
            // btn_cajones
            // 
            this.btn_cajones.FlatAppearance.BorderSize = 0;
            this.btn_cajones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_cajones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cajones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cajones.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cajones.ForeColor = System.Drawing.Color.White;
            this.btn_cajones.Image = ((System.Drawing.Image)(resources.GetObject("btn_cajones.Image")));
            this.btn_cajones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cajones.Location = new System.Drawing.Point(-2, 49);
            this.btn_cajones.Name = "btn_cajones";
            this.btn_cajones.Size = new System.Drawing.Size(200, 40);
            this.btn_cajones.TabIndex = 17;
            this.btn_cajones.Text = "Cajones y tarifas";
            this.btn_cajones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cajones.UseVisualStyleBackColor = true;
            this.btn_cajones.Click += new System.EventHandler(this.btn_cajones_Click);
            // 
            // btn_empleados
            // 
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.White;
            this.btn_empleados.Image = ((System.Drawing.Image)(resources.GetObject("btn_empleados.Image")));
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 3);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(200, 40);
            this.btn_empleados.TabIndex = 16;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            this.btn_empleados.Click += new System.EventHandler(this.btn_empleados_Click);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_configuracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracion.ForeColor = System.Drawing.Color.White;
            this.btn_configuracion.Image = ((System.Drawing.Image)(resources.GetObject("btn_configuracion.Image")));
            this.btn_configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_configuracion.Location = new System.Drawing.Point(-2, 419);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(200, 40);
            this.btn_configuracion.TabIndex = 15;
            this.btn_configuracion.Text = "Configuración";
            this.btn_configuracion.UseVisualStyleBackColor = true;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_servicios
            // 
            this.btn_servicios.FlatAppearance.BorderSize = 0;
            this.btn_servicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_servicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servicios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servicios.ForeColor = System.Drawing.Color.White;
            this.btn_servicios.Image = ((System.Drawing.Image)(resources.GetObject("btn_servicios.Image")));
            this.btn_servicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_servicios.Location = new System.Drawing.Point(-1, 327);
            this.btn_servicios.Name = "btn_servicios";
            this.btn_servicios.Size = new System.Drawing.Size(200, 40);
            this.btn_servicios.TabIndex = 14;
            this.btn_servicios.Text = "Servicios";
            this.btn_servicios.UseVisualStyleBackColor = true;
            this.btn_servicios.Click += new System.EventHandler(this.btn_servicios_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.BackColor = System.Drawing.Color.Transparent;
            this.btn_switch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_switch.BackgroundImage")));
            this.btn_switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_switch.FlatAppearance.BorderSize = 0;
            this.btn_switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switch.Location = new System.Drawing.Point(3, 5);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(25, 25);
            this.btn_switch.TabIndex = 1;
            this.btn_switch.UseVisualStyleBackColor = false;
            this.btn_switch.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_ticket_p
            // 
            this.btn_ticket_p.FlatAppearance.BorderSize = 0;
            this.btn_ticket_p.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_ticket_p.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ticket_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticket_p.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ticket_p.ForeColor = System.Drawing.Color.White;
            this.btn_ticket_p.Image = ((System.Drawing.Image)(resources.GetObject("btn_ticket_p.Image")));
            this.btn_ticket_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ticket_p.Location = new System.Drawing.Point(2, 143);
            this.btn_ticket_p.Name = "btn_ticket_p";
            this.btn_ticket_p.Size = new System.Drawing.Size(200, 40);
            this.btn_ticket_p.TabIndex = 7;
            this.btn_ticket_p.Text = "Pagar Ticket";
            this.btn_ticket_p.UseVisualStyleBackColor = true;
            this.btn_ticket_p.Click += new System.EventHandler(this.btn_ticket_p_Click);
            // 
            // btn_generar_rep
            // 
            this.btn_generar_rep.FlatAppearance.BorderSize = 0;
            this.btn_generar_rep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_generar_rep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_generar_rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generar_rep.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_rep.ForeColor = System.Drawing.Color.White;
            this.btn_generar_rep.Image = ((System.Drawing.Image)(resources.GetObject("btn_generar_rep.Image")));
            this.btn_generar_rep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generar_rep.Location = new System.Drawing.Point(-2, 281);
            this.btn_generar_rep.Name = "btn_generar_rep";
            this.btn_generar_rep.Size = new System.Drawing.Size(200, 40);
            this.btn_generar_rep.TabIndex = 6;
            this.btn_generar_rep.Text = "Generar reporte";
            this.btn_generar_rep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_generar_rep.UseVisualStyleBackColor = true;
            this.btn_generar_rep.Click += new System.EventHandler(this.btn_generar_rep_Click);
            // 
            // btn_genrar_con
            // 
            this.btn_genrar_con.FlatAppearance.BorderSize = 0;
            this.btn_genrar_con.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_genrar_con.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_genrar_con.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genrar_con.Font = new System.Drawing.Font("Arial Black", 12.5F, System.Drawing.FontStyle.Bold);
            this.btn_genrar_con.ForeColor = System.Drawing.Color.White;
            this.btn_genrar_con.Image = ((System.Drawing.Image)(resources.GetObject("btn_genrar_con.Image")));
            this.btn_genrar_con.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_genrar_con.Location = new System.Drawing.Point(-2, 235);
            this.btn_genrar_con.Name = "btn_genrar_con";
            this.btn_genrar_con.Size = new System.Drawing.Size(200, 40);
            this.btn_genrar_con.TabIndex = 5;
            this.btn_genrar_con.Text = "Contrato";
            this.btn_genrar_con.UseVisualStyleBackColor = true;
            this.btn_genrar_con.Click += new System.EventHandler(this.btn_genrar_con_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(2, 189);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(200, 40);
            this.btn_cliente.TabIndex = 4;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_genrar_t
            // 
            this.btn_genrar_t.FlatAppearance.BorderSize = 0;
            this.btn_genrar_t.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_genrar_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_genrar_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_genrar_t.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.btn_genrar_t.ForeColor = System.Drawing.Color.White;
            this.btn_genrar_t.Image = ((System.Drawing.Image)(resources.GetObject("btn_genrar_t.Image")));
            this.btn_genrar_t.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_genrar_t.Location = new System.Drawing.Point(0, 97);
            this.btn_genrar_t.Name = "btn_genrar_t";
            this.btn_genrar_t.Size = new System.Drawing.Size(200, 40);
            this.btn_genrar_t.TabIndex = 3;
            this.btn_genrar_t.Text = "Generar ticket";
            this.btn_genrar_t.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_genrar_t.UseVisualStyleBackColor = true;
            this.btn_genrar_t.Click += new System.EventHandler(this.btn_genrar_t_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(0, 51);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(200, 40);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_soft
            // 
            this.lbl_soft.AutoSize = true;
            this.lbl_soft.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_soft.ForeColor = System.Drawing.Color.White;
            this.lbl_soft.Location = new System.Drawing.Point(32, 3);
            this.lbl_soft.Name = "lbl_soft";
            this.lbl_soft.Size = new System.Drawing.Size(207, 19);
            this.lbl_soft.TabIndex = 9;
            this.lbl_soft.Text = "Software estacionamiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(54)))), ((int)(((byte)(76)))));
            this.pnl_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_titulo.Controls.Add(this.btn_cerrar);
            this.pnl_titulo.Controls.Add(this.lbl_soft);
            this.pnl_titulo.Controls.Add(this.pictureBox1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1285, 30);
            this.pnl_titulo.TabIndex = 1;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(1257, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_opciones_Click_2);
            // 
            // pnl_inicio
            // 
            this.pnl_inicio.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_inicio.Location = new System.Drawing.Point(200, 30);
            this.pnl_inicio.Name = "pnl_inicio";
            this.pnl_inicio.Size = new System.Drawing.Size(1085, 670);
            this.pnl_inicio.TabIndex = 2;
            this.pnl_inicio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_inicio_Paint);
            // 
            // tmr_abrirm
            // 
            this.tmr_abrirm.Interval = 1;
            this.tmr_abrirm.Tick += new System.EventHandler(this.tmr_abrirm_Tick);
            // 
            // tmr_ocultarm
            // 
            this.tmr_ocultarm.Interval = 1;
            this.tmr_ocultarm.Tick += new System.EventHandler(this.tmr_ocultarm_Tick);
            // 
            // tmr_abrirop
            // 
            this.tmr_abrirop.Interval = 1;
            this.tmr_abrirop.Tick += new System.EventHandler(this.tmr_abrirop_Tick);
            // 
            // tmr_ocultarop
            // 
            this.tmr_ocultarop.Interval = 1;
            this.tmr_ocultarop.Tick += new System.EventHandler(this.tmr_ocultarop_Tick);
            // 
            // tmr_abrir_frm
            // 
            this.tmr_abrir_frm.Interval = 2;
            this.tmr_abrir_frm.Tick += new System.EventHandler(this.tmr_abrir_frm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 700);
            this.Controls.Add(this.pnl_inicio);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_config.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Button btn_genrar_t;
        private System.Windows.Forms.Button btn_ticket_p;
        private System.Windows.Forms.Button btn_generar_rep;
        private System.Windows.Forms.Button btn_genrar_con;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel pnl_inicio;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.Timer tmr_abrirm;
        private System.Windows.Forms.Timer tmr_ocultarm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_soft;
        private System.Windows.Forms.Timer tmr_abrirop;
        private System.Windows.Forms.Timer tmr_ocultarop;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Button btn_servicios;
        private System.Windows.Forms.Panel pnl_config;
        private System.Windows.Forms.Button btn_cajones;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Timer tmr_abrir_frm;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_realizar_c;
        private System.Windows.Forms.Button btn_turnos;
    }
}

