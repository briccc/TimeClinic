namespace TimeClinic.DoctorControl
{
    partial class DoctorTabs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BLIstaTurnos = new System.Windows.Forms.Button();
            this.BHistorialPacientes = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BSalir);
            this.panel1.Controls.Add(this.BHistorialPacientes);
            this.panel1.Controls.Add(this.BLIstaTurnos);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 580);
            this.panel1.TabIndex = 2;
            // 
            // BLIstaTurnos
            // 
            this.BLIstaTurnos.BackColor = System.Drawing.Color.White;
            this.BLIstaTurnos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BLIstaTurnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BLIstaTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLIstaTurnos.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLIstaTurnos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BLIstaTurnos.Location = new System.Drawing.Point(0, 0);
            this.BLIstaTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.BLIstaTurnos.Name = "BLIstaTurnos";
            this.BLIstaTurnos.Size = new System.Drawing.Size(235, 41);
            this.BLIstaTurnos.TabIndex = 4;
            this.BLIstaTurnos.Text = "Lista de Turnos";
            this.BLIstaTurnos.UseVisualStyleBackColor = false;
            // 
            // BHistorialPacientes
            // 
            this.BHistorialPacientes.BackColor = System.Drawing.Color.White;
            this.BHistorialPacientes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BHistorialPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BHistorialPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHistorialPacientes.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHistorialPacientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BHistorialPacientes.Location = new System.Drawing.Point(0, 38);
            this.BHistorialPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.BHistorialPacientes.Name = "BHistorialPacientes";
            this.BHistorialPacientes.Size = new System.Drawing.Size(235, 41);
            this.BHistorialPacientes.TabIndex = 5;
            this.BHistorialPacientes.Text = "Historial Pacientes";
            this.BHistorialPacientes.UseVisualStyleBackColor = false;
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.White;
            this.BSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BSalir.Location = new System.Drawing.Point(0, 412);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(235, 41);
            this.BSalir.TabIndex = 6;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            // 
            // DoctorTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1033, 453);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorTabs";
            this.Text = "DoctorTabs";
            this.Load += new System.EventHandler(this.DoctorTabs_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BHistorialPacientes;
        private System.Windows.Forms.Button BLIstaTurnos;
    }
}