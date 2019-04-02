namespace Estacionamiento.GUI
{
    partial class Turnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_editarturno = new System.Windows.Forms.Button();
            this.btn_Agregarturno = new System.Windows.Forms.Button();
            this.txt_nombreturno = new System.Windows.Forms.TextBox();
            this.lbl_nombreturno = new System.Windows.Forms.Label();
            this.btn_eliminarturno = new System.Windows.Forms.Button();
            this.dtp_horainicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_horainicial = new System.Windows.Forms.Label();
            this.lbl_horafinal = new System.Windows.Forms.Label();
            this.dtp_horafinal = new System.Windows.Forms.DateTimePicker();
            this.dgv_turnos = new System.Windows.Forms.DataGridView();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idturno = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editarturno
            // 
            this.btn_editarturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_editarturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_editarturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editarturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarturno.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_editarturno.ForeColor = System.Drawing.Color.White;
            this.btn_editarturno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editarturno.Location = new System.Drawing.Point(370, 81);
            this.btn_editarturno.Name = "btn_editarturno";
            this.btn_editarturno.Size = new System.Drawing.Size(145, 38);
            this.btn_editarturno.TabIndex = 26;
            this.btn_editarturno.Text = "Editar turno";
            this.btn_editarturno.UseVisualStyleBackColor = false;
            this.btn_editarturno.Click += new System.EventHandler(this.btn_editarturno_Click);
            // 
            // btn_Agregarturno
            // 
            this.btn_Agregarturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_Agregarturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Agregarturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Agregarturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregarturno.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Agregarturno.ForeColor = System.Drawing.Color.White;
            this.btn_Agregarturno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregarturno.Location = new System.Drawing.Point(370, 37);
            this.btn_Agregarturno.Name = "btn_Agregarturno";
            this.btn_Agregarturno.Size = new System.Drawing.Size(145, 38);
            this.btn_Agregarturno.TabIndex = 25;
            this.btn_Agregarturno.Text = "Agregar turno";
            this.btn_Agregarturno.UseVisualStyleBackColor = false;
            this.btn_Agregarturno.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // txt_nombreturno
            // 
            this.txt_nombreturno.Location = new System.Drawing.Point(227, 65);
            this.txt_nombreturno.Name = "txt_nombreturno";
            this.txt_nombreturno.Size = new System.Drawing.Size(109, 20);
            this.txt_nombreturno.TabIndex = 24;
            // 
            // lbl_nombreturno
            // 
            this.lbl_nombreturno.AutoSize = true;
            this.lbl_nombreturno.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_nombreturno.Location = new System.Drawing.Point(68, 68);
            this.lbl_nombreturno.Name = "lbl_nombreturno";
            this.lbl_nombreturno.Size = new System.Drawing.Size(135, 18);
            this.lbl_nombreturno.TabIndex = 23;
            this.lbl_nombreturno.Text = "Nombre del turno";
            // 
            // btn_eliminarturno
            // 
            this.btn_eliminarturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btn_eliminarturno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eliminarturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminarturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarturno.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_eliminarturno.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarturno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarturno.Location = new System.Drawing.Point(370, 125);
            this.btn_eliminarturno.Name = "btn_eliminarturno";
            this.btn_eliminarturno.Size = new System.Drawing.Size(145, 38);
            this.btn_eliminarturno.TabIndex = 27;
            this.btn_eliminarturno.Text = "Eliminar turno";
            this.btn_eliminarturno.UseVisualStyleBackColor = false;
            this.btn_eliminarturno.Click += new System.EventHandler(this.btn_eliminarturno_Click);
            // 
            // dtp_horainicial
            // 
            this.dtp_horainicial.Checked = false;
            this.dtp_horainicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horainicial.Location = new System.Drawing.Point(227, 91);
            this.dtp_horainicial.Name = "dtp_horainicial";
            this.dtp_horainicial.Size = new System.Drawing.Size(110, 20);
            this.dtp_horainicial.TabIndex = 28;
            this.dtp_horainicial.ValueChanged += new System.EventHandler(this.dtp_horainicial_ValueChanged);
            // 
            // lbl_horainicial
            // 
            this.lbl_horainicial.AutoSize = true;
            this.lbl_horainicial.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_horainicial.Location = new System.Drawing.Point(112, 93);
            this.lbl_horainicial.Name = "lbl_horainicial";
            this.lbl_horainicial.Size = new System.Drawing.Size(91, 18);
            this.lbl_horainicial.TabIndex = 29;
            this.lbl_horainicial.Text = "Hora Inicial";
            // 
            // lbl_horafinal
            // 
            this.lbl_horafinal.AutoSize = true;
            this.lbl_horafinal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_horafinal.Location = new System.Drawing.Point(121, 122);
            this.lbl_horafinal.Name = "lbl_horafinal";
            this.lbl_horafinal.Size = new System.Drawing.Size(82, 18);
            this.lbl_horafinal.TabIndex = 30;
            this.lbl_horafinal.Text = "Hora Final";
            // 
            // dtp_horafinal
            // 
            this.dtp_horafinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horafinal.Location = new System.Drawing.Point(227, 122);
            this.dtp_horafinal.Name = "dtp_horafinal";
            this.dtp_horafinal.Size = new System.Drawing.Size(110, 20);
            this.dtp_horafinal.TabIndex = 31;
            // 
            // dgv_turnos
            // 
            this.dgv_turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_turno,
            this.hora_inicial,
            this.hora_final,
            this.tipo_turno});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_turnos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turnos.Location = new System.Drawing.Point(71, 213);
            this.dgv_turnos.Name = "dgv_turnos";
            this.dgv_turnos.Size = new System.Drawing.Size(650, 195);
            this.dgv_turnos.TabIndex = 32;
            this.dgv_turnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_turnos_CellContentClick);
            this.dgv_turnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_turnos_CellDoubleClick);
            this.dgv_turnos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_turnos_CellMouseClick);
            // 
            // id_turno
            // 
            this.id_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_turno.DataPropertyName = "id_turno";
            this.id_turno.HeaderText = "Id Turno";
            this.id_turno.Name = "id_turno";
            // 
            // hora_inicial
            // 
            this.hora_inicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hora_inicial.DataPropertyName = "hora_inicial";
            this.hora_inicial.HeaderText = "Hora Inicial";
            this.hora_inicial.Name = "hora_inicial";
            // 
            // hora_final
            // 
            this.hora_final.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hora_final.DataPropertyName = "hora_final";
            this.hora_final.HeaderText = "Hora final";
            this.hora_final.Name = "hora_final";
            // 
            // tipo_turno
            // 
            this.tipo_turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_turno.DataPropertyName = "tipo_turno";
            this.tipo_turno.HeaderText = "Nombre Del Turno";
            this.tipo_turno.Name = "tipo_turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id Turno";
            // 
            // txt_idturno
            // 
            this.txt_idturno.Enabled = false;
            this.txt_idturno.Location = new System.Drawing.Point(227, 37);
            this.txt_idturno.Name = "txt_idturno";
            this.txt_idturno.Size = new System.Drawing.Size(109, 20);
            this.txt_idturno.TabIndex = 34;
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
            this.btn_limpiar.Location = new System.Drawing.Point(370, 169);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(145, 38);
            this.btn_limpiar.TabIndex = 35;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.txt_idturno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_turnos);
            this.Controls.Add(this.dtp_horafinal);
            this.Controls.Add(this.lbl_horafinal);
            this.Controls.Add(this.lbl_horainicial);
            this.Controls.Add(this.dtp_horainicial);
            this.Controls.Add(this.btn_eliminarturno);
            this.Controls.Add(this.btn_editarturno);
            this.Controls.Add(this.btn_Agregarturno);
            this.Controls.Add(this.txt_nombreturno);
            this.Controls.Add(this.lbl_nombreturno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turnos";
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editarturno;
        private System.Windows.Forms.Button btn_Agregarturno;
        private System.Windows.Forms.TextBox txt_nombreturno;
        private System.Windows.Forms.Label lbl_nombreturno;
        private System.Windows.Forms.Button btn_eliminarturno;
        private System.Windows.Forms.DateTimePicker dtp_horainicial;
        private System.Windows.Forms.Label lbl_horainicial;
        private System.Windows.Forms.Label lbl_horafinal;
        private System.Windows.Forms.DateTimePicker dtp_horafinal;
        private System.Windows.Forms.DataGridView dgv_turnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idturno;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_turno;
    }
}