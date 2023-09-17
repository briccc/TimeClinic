namespace TimeClinic.Doctor.DoctorControl
{
    partial class UC_ListaTurnos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAgregarReceta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BAgregarNuevaReceta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(280, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(485, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Para agregar una nueva receta presione el boton agregar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_turno,
            this.nombre_paciente,
            this.apellido_paciente,
            this.fecha_turno,
            this.BAgregarReceta});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(99, 152);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(671, 357);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(364, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de Turnos";
            // 
            // Id_turno
            // 
            this.Id_turno.HeaderText = "ID Turno";
            this.Id_turno.MinimumWidth = 6;
            this.Id_turno.Name = "Id_turno";
            this.Id_turno.Width = 125;
            // 
            // nombre_paciente
            // 
            this.nombre_paciente.HeaderText = "Nombre";
            this.nombre_paciente.MinimumWidth = 6;
            this.nombre_paciente.Name = "nombre_paciente";
            this.nombre_paciente.Width = 125;
            // 
            // apellido_paciente
            // 
            this.apellido_paciente.HeaderText = "Apellido";
            this.apellido_paciente.MinimumWidth = 6;
            this.apellido_paciente.Name = "apellido_paciente";
            this.apellido_paciente.Width = 125;
            // 
            // fecha_turno
            // 
            this.fecha_turno.HeaderText = "Fecha de Nacimiento";
            this.fecha_turno.MinimumWidth = 6;
            this.fecha_turno.Name = "fecha_turno";
            this.fecha_turno.Width = 125;
            // 
            // BAgregarReceta
            // 
            this.BAgregarReceta.HeaderText = "Agregar Receta";
            this.BAgregarReceta.MinimumWidth = 6;
            this.BAgregarReceta.Name = "BAgregarReceta";
            this.BAgregarReceta.Width = 125;
            // 
            // BAgregarNuevaReceta
            // 
            this.BAgregarNuevaReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.BAgregarNuevaReceta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.BAgregarNuevaReceta.FlatAppearance.BorderSize = 2;
            this.BAgregarNuevaReceta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.BAgregarNuevaReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.BAgregarNuevaReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarNuevaReceta.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarNuevaReceta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BAgregarNuevaReceta.Location = new System.Drawing.Point(789, 198);
            this.BAgregarNuevaReceta.Margin = new System.Windows.Forms.Padding(4);
            this.BAgregarNuevaReceta.Name = "BAgregarNuevaReceta";
            this.BAgregarNuevaReceta.Size = new System.Drawing.Size(136, 42);
            this.BAgregarNuevaReceta.TabIndex = 21;
            this.BAgregarNuevaReceta.Text = "Agregar";
            this.BAgregarNuevaReceta.UseVisualStyleBackColor = false;
            this.BAgregarNuevaReceta.Click += new System.EventHandler(this.BAgregarNuevaReceta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_ListaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BAgregarNuevaReceta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_ListaTurnos";
            this.Size = new System.Drawing.Size(956, 546);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_turno;
        private System.Windows.Forms.DataGridViewButtonColumn BAgregarReceta;
        private System.Windows.Forms.Button BAgregarNuevaReceta;
        private System.Windows.Forms.Button button1;
    }
}
