using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Programación_II.FormProfesor
{
    public partial class FormProfe : Form
    {
        public FormProfe()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            FormInstituto formPrincipal = new FormInstituto();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInstituto formInstituto = new FormInstituto();
            formInstituto.Show(); // Muestra el formulario FormInstituto
            this.Close(); // Cierra el formulario actual (FormProfe)
        }
    }
}
