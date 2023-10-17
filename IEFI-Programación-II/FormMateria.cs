using Entidades.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace IEFI_Programación_II
{
    public partial class FormMateria : Form
    {
        // Creamos una instancia de la clase AdministracionMaterias para realizar operaciones de base de datos.
        AdministracionMaterias objMaterias = new AdministracionMaterias();

        public FormMateria()
        {
            InitializeComponent();
        }

        // Este método se ejecuta cuando se hace clic en el botón "Guardar".
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario
            string nombreMateria = Txt_Nombre.Text;
            int legajoProfesor = Convert.ToInt32(Txt_Legajo.Text);
            bool estado = Checkbox_Estado.Checked;

            // Crear un objeto Materia con los datos ingresados.
            Materia materia = new Materia
            {
                PNombre = nombreMateria,
                PLegajoProfesor = legajoProfesor,
                PEstado = estado
            };

            // Realizr la operación  agregar la materia llamando al método abmMaterias de AdministracionMaterias.
            int resultado = objMaterias.abmMaterias("Alta", materia);

            // Comprobar si la operación fue exitosa y mostrar un mensaje.
            if (resultado > 0)
            {
                MessageBox.Show("Materia agregada correctamente");
                LimpiarFormulario(); // Limpia el formulario después de agregar una materia.
            }
            else
            {
                MessageBox.Show("Error al agregar la materia");
            }
        }

        // Este método se ejecuta cuando se hace clic en el botón "Cargar".
        private void btnCargar_Click(object sender, EventArgs e)
        {
            string codigo = Txt_Codigo.Text;

            // Realizar una búsqueda de materias según el código ingresado llamando al método listadoMaterias de AdministracionMaterias.
            DataSet ds = objMaterias.listadoMaterias(codigo);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // Si se encontraron datos, mostrarlos en las etiquetas del formulario llamando al método MostrarDatosMateria.
                DataRow row = ds.Tables[0].Rows[0];
                Materia materia = new Materia
                {
                    PNombre = row["Nombre"].ToString(),
                    PLegajoProfesor = Convert.ToInt32(row["LegajoProfesor"]),
                    PEstado = Convert.ToBoolean(row["Estado"])
                };

                MostrarDatosMateria(materia);
            }
            else
            {
                MessageBox.Show("Materia no encontrada");
            }
        }

        // Este método muestra los datos de una materia en las etiquetas del formulario.
        private void MostrarDatosMateria(Materia materia)
        {
            Lbl_Nombre.Text = "Nombre: " + materia.PNombre;
            Lbl_Legajo.Text = "Legajo del Profesor: " + materia.PLegajoProfesor;
            Lbl_Estado.Text = "Estado: " + (materia.PEstado ? "Activa" : "Inactiva");
        }

        // Este método limpia los campos de entrada en el formulario y las etiquetas que muestran los datos.
        private void LimpiarFormulario()
        {
            Txt_Nombre.Text = "";
            Txt_Legajo.Text = "";
            Txt_Codigo.Text = "";
            Checkbox_Estado.Checked = false;

            Lbl_Nombre.Text = "Nombre: ";
            Lbl_Legajo.Text = "Legajo del Profesor: ";
            Lbl_Estado.Text = "Estado: ";
        }

        // Este método se ejecuta cuando se hace clic en el botón "Salir" y cierra el formulario.
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}