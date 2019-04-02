namespace Estacionamiento.GUI
{
    partial class vehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiculos));
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminarvehiculo = new System.Windows.Forms.Button();
            this.btn_editarvehiculo = new System.Windows.Forms.Button();
            this.btn_Agregarvehiculo = new System.Windows.Forms.Button();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_nombreturno = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(376, 172);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(145, 38);
            this.btn_limpiar.TabIndex = 44;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(233, 40);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(109, 20);
            this.txt_id_cliente.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Numero De Cliente";
            // 
            // dgv_vehiculos
            // 
            this.dgv_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.apellido_paterno,
            this.aellido_materno,
            this.matricula,
            this.modelo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vehiculos.Location = new System.Drawing.Point(77, 216);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.Size = new System.Drawing.Size(650, 195);
            this.dgv_vehiculos.TabIndex = 41;
            this.dgv_vehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehiculos_CellContentClick);
            this.dgv_vehiculos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_vehiculos_CellMouseClick);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "Numero de Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "Apellido Paterno";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // aellido_materno
            // 
            this.aellido_materno.DataPropertyName = "aellido_materno";
            this.aellido_materno.HeaderText = "Apellido Materno";
            this.aellido_materno.Name = "aellido_materno";
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "matricula";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // btn_eliminarvehiculo
            // 
            this.btn_eliminarvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_eliminarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarvehiculo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_eliminarvehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarvehiculo.Location = new System.Drawing.Point(376, 128);
            this.btn_eliminarvehiculo.Name = "btn_eliminarvehiculo";
            this.btn_eliminarvehiculo.Size = new System.Drawing.Size(145, 38);
            this.btn_eliminarvehiculo.TabIndex = 40;
            this.btn_eliminarvehiculo.Text = "Eliminar vehiculo";
            this.btn_eliminarvehiculo.UseVisualStyleBackColor = false;
            this.btn_eliminarvehiculo.Click += new System.EventHandler(this.btn_eliminarvehiculo_Click);
            // 
            // btn_editarvehiculo
            // 
            this.btn_editarvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_editarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarvehiculo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_editarvehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_editarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarvehiculo.Location = new System.Drawing.Point(376, 84);
            this.btn_editarvehiculo.Name = "btn_editarvehiculo";
            this.btn_editarvehiculo.Size = new System.Drawing.Size(145, 38);
            this.btn_editarvehiculo.TabIndex = 39;
            this.btn_editarvehiculo.Text = "Editar vehiculo";
            this.btn_editarvehiculo.UseVisualStyleBackColor = false;
            this.btn_editarvehiculo.Click += new System.EventHandler(this.btn_editarvehiculo_Click);
            // 
            // btn_Agregarvehiculo
            // 
            this.btn_Agregarvehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_Agregarvehiculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Agregarvehiculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Agregarvehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregarvehiculo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Agregarvehiculo.ForeColor = System.Drawing.Color.White;
            this.btn_Agregarvehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregarvehiculo.Location = new System.Drawing.Point(376, 40);
            this.btn_Agregarvehiculo.Name = "btn_Agregarvehiculo";
            this.btn_Agregarvehiculo.Size = new System.Drawing.Size(145, 38);
            this.btn_Agregarvehiculo.TabIndex = 38;
            this.btn_Agregarvehiculo.Text = "Agregar vehiculo";
            this.btn_Agregarvehiculo.UseVisualStyleBackColor = false;
            this.btn_Agregarvehiculo.Click += new System.EventHandler(this.btn_Agregarvehiculo_Click);
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(233, 72);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(109, 20);
            this.txt_matricula.TabIndex = 37;
            // 
            // lbl_nombreturno
            // 
            this.lbl_nombreturno.AutoSize = true;
            this.lbl_nombreturno.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_nombreturno.Location = new System.Drawing.Point(133, 74);
            this.lbl_nombreturno.Name = "lbl_nombreturno";
            this.lbl_nombreturno.Size = new System.Drawing.Size(76, 18);
            this.lbl_nombreturno.TabIndex = 36;
            this.lbl_nombreturno.Text = "Matricula";
            this.lbl_nombreturno.Click += new System.EventHandler(this.lbl_nombreturno_Click);
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(233, 102);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(109, 20);
            this.txt_modelo.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(141, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Modelo";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(774, 1);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(25, 25);
            this.btn_cerrar.TabIndex = 47;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_vehiculos);
            this.Controls.Add(this.btn_eliminarvehiculo);
            this.Controls.Add(this.btn_editarvehiculo);
            this.Controls.Add(this.btn_Agregarvehiculo);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_nombreturno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehiculos";
            this.Text = "vehiculos";
            this.Load += new System.EventHandler(this.vehiculos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vehiculos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
        private System.Windows.Forms.Button btn_eliminarvehiculo;
        private System.Windows.Forms.Button btn_editarvehiculo;
        private System.Windows.Forms.Button btn_Agregarvehiculo;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_nombreturno;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.Button btn_cerrar;
    }
}