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
using TimeClinic.Recepcionista.RecepcionistaControl;

namespace TimeClinic.Recepcionista
{
    public partial class RecepcionistaTabs : Form
    {
        public RecepcionistaTabs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            UC_InicioRecepcionista uc = new UC_InicioRecepcionista();
            addUserControl(uc);
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelRecContainer.Controls.Clear();
            panelRecContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void BInicio_Click(object sender, EventArgs e)
        {
            UC_InicioRecepcionista uc = new UC_InicioRecepcionista();
            addUserControl(uc);
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNuevoPaciente_Click(object sender, EventArgs e)
        {
            UC_NuevoPaciente uc = new UC_NuevoPaciente();
            addUserControl(uc);
        }

        private void BNuevoTurno_Click(object sender, EventArgs e)
        {
            UC_NuevoTurno uc = new UC_NuevoTurno();
            addUserControl(uc);
        }

        private void BHistorialPacientes_Click(object sender, EventArgs e)
        {
            UC_HistorialPacientes uc = new UC_HistorialPacientes();
            addUserControl(uc);
        }

        private void BHistorialTurnos_Click(object sender, EventArgs e)
        {
            UC_HistorialTurnos uc = new UC_HistorialTurnos();
            addUserControl(uc);
        }

        private void recepcionistaTabPanel_Paint(object sender, PaintEventArgs e)
        {
            recepcionistaTabPanel.Height = this.ClientSize.Height;
        }

        private void RecepcionistaTabs_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRecContainer_Paint(object sender, PaintEventArgs e)
        {
            CenterContent();
        }
        private void CenterContent()
        {
            // Calculate the center position
            int centerX = (this.Width - panelRecContainer.Width) / 2;
            int centerY = (this.Height - panelRecContainer.Height) / 2;

            // Set the location of the container control to center
            panelRecContainer.Location = new Point(centerX, centerY);
        }
    }
}
