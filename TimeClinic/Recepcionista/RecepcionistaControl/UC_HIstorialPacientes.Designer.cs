namespace TimeClinic.Recepcionista.RecepcionistaControl
{
    partial class UC_HIstorialPacientes
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
            this.TablaHistorialPacientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dni_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanac_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BVerMas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TBEditarPaciente = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorialPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(309, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Para ver información detallada sobre cada paciente presionar ver más";
            // 
            // TablaHistorialPacientes
            // 
            this.TablaHistorialPacientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TablaHistorialPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaHistorialPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni_paciente,
            this.nombre_paciente,
            this.apellido_paciente,
            this.telefono_paciente,
            this.direc_paciente,
            this.fechanac_paciente,
            this.BVerMas,
            this.TBEditarPaciente});
            this.TablaHistorialPacientes.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TablaHistorialPacientes.Location = new System.Drawing.Point(83, 150);
            this.TablaHistorialPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.TablaHistorialPacientes.Name = "TablaHistorialPacientes";
            this.TablaHistorialPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TablaHistorialPacientes.Size = new System.Drawing.Size(1046, 357);
            this.TablaHistorialPacientes.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(384, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Historial de Pacientes";
            // 
            // dni_paciente
            // 
            this.dni_paciente.HeaderText = "DNI";
            this.dni_paciente.MinimumWidth = 6;
            this.dni_paciente.Name = "dni_paciente";
            this.dni_paciente.Width = 125;
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
            // telefono_paciente
            // 
            this.telefono_paciente.HeaderText = "Teléfono";
            this.telefono_paciente.MinimumWidth = 6;
            this.telefono_paciente.Name = "telefono_paciente";
            this.telefono_paciente.Width = 125;
            // 
            // direc_paciente
            // 
            this.direc_paciente.HeaderText = "Dirección";
            this.direc_paciente.MinimumWidth = 6;
            this.direc_paciente.Name = "direc_paciente";
            this.direc_paciente.Width = 125;
            // 
            // fechanac_paciente
            // 
            this.fechanac_paciente.HeaderText = "Fecha de Nacimiento";
            this.fechanac_paciente.MinimumWidth = 6;
            this.fechanac_paciente.Name = "fechanac_paciente";
            this.fechanac_paciente.Width = 125;
            // 
            // BVerMas
            // 
            this.BVerMas.HeaderText = "Ver más";
            this.BVerMas.MinimumWidth = 6;
            this.BVerMas.Name = "BVerMas";
            this.BVerMas.Width = 125;
            // 
            // TBEditarPaciente
            // 
            this.TBEditarPaciente.HeaderText = "Editar";
            this.TBEditarPaciente.MinimumWidth = 6;
            this.TBEditarPaciente.Name = "TBEditarPaciente";
            this.TBEditarPaciente.Width = 125;
            // 
            // UC_HIstorialPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TablaHistorialPacientes);
            this.Controls.Add(this.label1);
            this.Name = "UC_HIstorialPacientes";
            this.Size = new System.Drawing.Size(1215, 832);
            ((System.ComponentModel.ISupportInitialize)(this.TablaHistorialPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TablaHistorialPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanac_paciente;
        private System.Windows.Forms.DataGridViewButtonColumn BVerMas;
        private System.Windows.Forms.DataGridViewButtonColumn TBEditarPaciente;
    }
}
