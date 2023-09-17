using System;
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
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
            
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Height = this.ClientSize.Height;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {

        }

        private void BHistorialPacientes_Click(object sender, EventArgs e)
        {
            UC_HistorialPacientes uc = new UC_HistorialPacientes();
            addUserControl(uc);
        }

        private void BListaTurnos_Click(object sender, EventArgs e)
        {

        }
    }
}
