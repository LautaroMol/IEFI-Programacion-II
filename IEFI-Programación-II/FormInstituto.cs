
using CapaDatos;
using IEFI_Programación_II.FormProfesor;

namespace IEFI_Programación_II
{
    public partial class FormInstituto : Form
    {

        public FormInstituto()
        {
            InitializeComponent();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            FormProfe formProfe = new FormProfe();
            formProfe.Show(); // Abre el formulario FormProfe
            this.Hide();
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            DatosdeConexion datosConexion = new DatosdeConexion();
            string cadenaConexion = datosConexion.CadenadeConexion;

            FormMateria formMateria = new FormMateria(cadenaConexion);
            formMateria.Show();  // Abre el formulario FormMateria
            this.Hide();  // Oculta el formulario actual (el que contiene el botón "btnMat").
        }
    }
}