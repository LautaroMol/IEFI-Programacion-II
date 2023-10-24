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
using CapaInstituto;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace IEFI_Programación_II
{
   public partial class FormMateria : Form
    {
        private ListadoMaterias listadoMaterias; // Una instancia de la capa de datos
        private string connectionString; // Declaración de la variable connectionString
        private AdministracionMaterias adminMaterias;
        public FormMateria(string connectionString)
        {
            InitializeComponent();

            adminMaterias = new AdministracionMaterias(connectionString);
            this.connectionString = connectionString; // Asignación del valor pasado como argumento
            // Inicializar la instancia de la capa de datos con la cadena de conexión
            listadoMaterias = new ListadoMaterias(connectionString);

            // Configurar el DataGridView
            Dgv_iniciar();

            // Llenar el DataGridView con los datos existentes en la base de datos
            LLenarDGV();
        }

        private void Dgv_iniciar()
        {
            // Configurar las columnas del DataGridView
            Dgv_Materias.AutoGenerateColumns = false;
            Dgv_Materias.Columns.Add("Codigo", "Código");
            Dgv_Materias.Columns.Add("LegajoProfesor", "Legajo Profesor");
            Dgv_Materias.Columns.Add("Estado", "Estado");
            Dgv_Materias.Columns.Add("Nombre", "Nombre");
        }

        private void LLenarDGV()
        {
            // Llenar el DataGridView con datos de la base de datos
            Dgv_Materias.Rows.Clear();

            // Obtener un conjunto de datos de materias
            DataSet ds = listadoMaterias.LisMaterias("Todos");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dgv_Materias.Rows.Add(dr["Codigo"], dr["LegajoProfesor"], dr["Estado"], dr["Nombre"]);
                }

                // Ajustar la columna de "Estado" para mostrar "Activo" o "Inactivo" en lugar de "True" o "False"
                foreach (DataGridViewRow row in Dgv_Materias.Rows)
                {
                    if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "True")
                    {
                        row.Cells[2].Value = "Activo";
                    }
                    else if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "False")
                    {
                        row.Cells[2].Value = "Inactivo";
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen materias en la base de datos.");
            }
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            // Recolectar los datos ingresados en los TextBox
            if (!int.TryParse(Txt_Codigo.Text, out int codigo) || !int.TryParse(Txt_Legajo.Text, out int legajo))
            {
                MessageBox.Show("Ingrese valores válidos para el código y el legajo, que solo contengan números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = Txt_Nombre.Text;
            bool estado = Checkbox_Estado.Checked;

            // Realiza la validación de código único
            if (!EsCodigoUnico(codigo))
            {
                MessageBox.Show("El código ingresado ya existe. Ingrese un código único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Realiza la validación de legajo único
            if (!EsLegajoUnico(legajo))
            {
                MessageBox.Show("El legajo ingresado ya existe. Ingrese un legajo único.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación para asegurarse de que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(Txt_Codigo.Text) || string.IsNullOrWhiteSpace(Txt_Legajo.Text) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación para el campo de nombre (solo letras)
            if (!EsNombreValido(nombre))
            {
                MessageBox.Show("El campo de nombre solo debe contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar una nueva fila al DataGridView
            Dgv_Materias.Rows.Add(codigo, legajo, estado ? "Activo" : "Inactivo", nombre);

            // Limpiar los TextBox
            Txt_Codigo.Clear();
            Txt_Legajo.Clear();
            Txt_Nombre.Clear();
            Checkbox_Estado.Checked = false;

            // Guardar los datos en la base de datos
            GuardarDatosEnBaseDeDatos(codigo, legajo, nombre, estado);
        }
        private void CargarDatosDesdeBaseDeDatos()
        {
            // Cargar datos existentes desde la base de datos y mostrarlos en el DGV
            DataSet ds = listadoMaterias.LisMaterias("Todos");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Dgv_Materias.Rows.Add(dr["Codigo"], dr["LegajoProfesor"], dr["Estado"], dr["Nombre"]);
                }
            }
        }
        private bool EsNombreValido(string nombre)
        {
            foreach (char c in nombre)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false; // Si encuentra un carácter que no es una letra ni un espacio, retorna falso
                }
            }
            return true; // Si todos los caracteres son letras o espacios, retorna verdadero
        }

        private bool EsCodigoUnico(int codigo)
        {
            foreach (DataGridViewRow row in Dgv_Materias.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false; // El código ya existe en una fila.
                }
            }
            return true; // El código es único.
        }

        private bool EsLegajoUnico(int legajo)
        {
            foreach (DataGridViewRow row in Dgv_Materias.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == legajo.ToString())
                {
                    return false; // El legajo ya existe en una fila.
                }
            }
            return true; // El legajo es único.
        }
        private void GuardarDatosEnBaseDeDatos(int codigo, int legajo, string nombre, bool estado)
        {
            // Guardar los datos en la base de datos
            Materia nuevaMateria = new Materia
            {
                Pcodigo = codigo,
                Plegajo = legajo,
                Pnombre = nombre,
                Pestado = estado
            };

            int resultado = listadoMaterias.abmMaterias("Agregar", nuevaMateria);

            if (resultado > 0)
            {
                MessageBox.Show("La materia se ha guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar la materia.");
            }
        }

        private void Btn_Atras_Click(object sender, EventArgs e)
        {
            FormInstituto formInstituto = new FormInstituto();
            formInstituto.Show(); // Muestra el formulario FormInstituto
            this.Close(); // Cierra el formulario actual (FormMateria)
        }

        private void Lbl_Cruz_Click(object sender, EventArgs e)
        {
            // Mostrar un modal de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Si el usuario confirma la salida, cierra el formulario actual
                this.Close();
                Application.Exit(); // Esto cierra la aplicación por completo
            }

        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila en el DataGridView
            if (Dgv_Materias.Rows.Count > 0)
            {
                // Verifica si se ha seleccionado una fila completa
                if (Dgv_Materias.SelectedRows.Count > 0)
                {
                    // Muestra un modal de confirmación.
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Obtiene la fila seleccionada.
                        DataGridViewRow filaSeleccionada = Dgv_Materias.SelectedRows[0];

                        // Verifica si la fila no está vacía.
                        if (filaSeleccionada != null && !filaSeleccionada.IsNewRow)
                        {
                            // Aquí obtén el valor del código de la materia que deseas eliminar.
                            int codigoMateria = int.Parse(filaSeleccionada.Cells["Codigo"].Value.ToString());

                            // Elimina la fila seleccionada del DataGridView.
                            Dgv_Materias.Rows.Remove(filaSeleccionada);

                            // Aquí también debes eliminar la materia de la base de datos.
                            EliminarMateriaDeBaseDeDatos(codigoMateria);
                        }
                    }
                }
                else
                {
                    // Modal de error si no se seleccionó una fila para borrar.
                    MessageBox.Show("No se ha seleccionado una fila para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Modal de error si no hay filas para borrar.
                MessageBox.Show("No hay filas para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarMateriaDeBaseDeDatos(int codigoMateria)
        {
            // Aquí debes implementar la lógica para eliminar la materia de la base de datos.
            // Puedes usar tu método AbmMaterias con la acción "Borrar" y el código de la materia.

            Materia materiaAEliminar = new Materia
            {
                Pcodigo = codigoMateria
            };

            int resultadoEliminacion = listadoMaterias.abmMaterias("Borrar", materiaAEliminar);

            if (resultadoEliminacion == -1)
            {
                MessageBox.Show("No se pudo borrar la materia de la base de datos.");
            }
            else
            {
                MessageBox.Show("Materia borrada de la base de datos.");
            }
        }

        private void Btn_Alegajo_Click(object sender, EventArgs e)
        {
            // Verifica si se ha ingresado un valor en el campo Txt_Alegajo
            if (string.IsNullOrEmpty(Txt_Alegajo.Text))
            {
                MessageBox.Show("Ingrese un nuevo legajo en el campo correspondiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si el valor ingresado es un número válido
            if (!int.TryParse(Txt_Alegajo.Text, out int nuevoLegajo))
            {
                MessageBox.Show("Ingrese un valor válido para el nuevo legajo, solo debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica si hay al menos una fila en el DataGridView
            if (Dgv_Materias.Rows.Count > 0)
            {
                // Verifica si se ha seleccionado una fila completa
                if (Dgv_Materias.SelectedRows.Count > 0)
                {
                    // Muestra un modal de confirmación.
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea actualizar el legajo de la materia seleccionada?", "Confirmar actualización de legajo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Obtiene el código de la materia seleccionada
                        int codigoMateria = int.Parse(Dgv_Materias.SelectedRows[0].Cells["Codigo"].Value.ToString());

                        // Actualiza el legajo en la base de datos
                        adminMaterias.ActualizarLegajoEnBaseDeDatos(codigoMateria, nuevoLegajo);

                        // Actualiza la fila en el DataGridView
                        Dgv_Materias.SelectedRows[0].Cells["LegajoProfesor"].Value = nuevoLegajo;

                        MessageBox.Show("Legajo actualizado para la materia seleccionada.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Modal de error si no se seleccionó una fila para actualizar el legajo
                    MessageBox.Show("No se ha seleccionado una materia para actualizar el legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Modal de error si no hay materias para actualizar el legajo
                MessageBox.Show("No hay materias para actualizar el legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


