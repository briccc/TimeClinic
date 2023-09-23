﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClinic.Doctor.DoctorControl;

namespace TimeClinic.DoctorControl
{
    public partial class DoctorTabs : Form
    {
        public DoctorTabs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            UC_InicioDoctor uc = new UC_InicioDoctor();
            addUserControl(uc);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void DoctorTabs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BHistorialPacientes_Click(object sender, EventArgs e)
        {
            UC_HistorialPacientes uc = new UC_HistorialPacientes();
            addUserControl(uc);
        }
        private void BListaTurnos_Click(object sender, EventArgs e)
        {
            UC_ListaTurnos uc = new UC_ListaTurnos(this);
            addUserControl(uc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_InicioDoctor uc = new UC_InicioDoctor();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            CenterContent();
        }

        private void CenterContent()
        {
            // Calculate the center position
            int centerX = (this.Width - panelContainer.Width) / 2;
            int centerY = (this.Height - panelContainer.Height) / 2;

            // Set the location of the container control to center
            panelContainer.Location = new Point(centerX, centerY);
        }
    }
}
