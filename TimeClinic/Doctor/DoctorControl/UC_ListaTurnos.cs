using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClinic.DoctorControl;

namespace TimeClinic.Doctor.DoctorControl
{
    public partial class UC_ListaTurnos : UserControl
    {
        private DoctorTabs doctorTabsForm;
        public UC_ListaTurnos(DoctorTabs form)
        {
            InitializeComponent();
            doctorTabsForm = form;
        }

        private void BAgregarNuevaReceta_Click(object sender, EventArgs e)
        {
            UC_AgregarReceta uc = new UC_AgregarReceta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del UserControl UC_AgregarReceta
            UC_AgregarReceta ucAgregarReceta = new UC_AgregarReceta();

            // Llama a la función addUserControl en el formulario DoctorTabs
            doctorTabsForm.addUserControl(ucAgregarReceta);
        }
    }
}
