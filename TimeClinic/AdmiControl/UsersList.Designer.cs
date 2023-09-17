namespace TimeClinic
{
    partial class UsersList
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direc_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanac_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 471);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(3, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo Usuario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(3, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lista de Usuarios";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(104)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(311, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nombre_usuario,
            this.apellido_usuario,
            this.correo_usuario,
            this.pass_usuario,
            this.perfil_usuario,
            this.dni_usuario,
            this.telefono_usuario,
            this.direc_usuario,
            this.fechanac_usuario});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(185, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 346);
            this.dataGridView1.TabIndex = 3;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Id_Usuario";
            this.id_usuario.Name = "id_usuario";
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.HeaderText = "Nombre";
            this.nombre_usuario.Name = "nombre_usuario";
            // 
            // apellido_usuario
            // 
            this.apellido_usuario.HeaderText = "Apellido";
            this.apellido_usuario.Name = "apellido_usuario";
            // 
            // correo_usuario
            // 
            this.correo_usuario.HeaderText = "Correo";
            this.correo_usuario.Name = "correo_usuario";
            // 
            // pass_usuario
            // 
            this.pass_usuario.HeaderText = "Contraseña";
            this.pass_usuario.Name = "pass_usuario";
            // 
            // perfil_usuario
            // 
            this.perfil_usuario.HeaderText = "Perfil";
            this.perfil_usuario.Name = "perfil_usuario";
            // 
            // dni_usuario
            // 
            this.dni_usuario.HeaderText = "DNI";
            this.dni_usuario.Name = "dni_usuario";
            // 
            // telefono_usuario
            // 
            this.telefono_usuario.HeaderText = "Teléfono";
            this.telefono_usuario.Name = "telefono_usuario";
            // 
            // direc_usuario
            // 
            this.direc_usuario.HeaderText = "Dirección";
            this.direc_usuario.Name = "direc_usuario";
            // 
            // fechanac_usuario
            // 
            this.fechanac_usuario.HeaderText = "Fecha de Nacimiento";
            this.fechanac_usuario.Name = "fechanac_usuario";
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(670, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UsersList";
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn direc_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanac_usuario;
    }
}