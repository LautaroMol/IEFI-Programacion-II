using CapaInstituto;
using System.Data;
using System.Drawing.Printing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;


namespace IEFI_Programación_II
{
    public partial class FormImprimir : Form
    {
        private ListadoMaterias listadoMaterias;
        private int currentRow;
        private DataTable dtCombinado = new DataTable();

        public FormImprimir(string connectionString)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
            listadoMaterias = new ListadoMaterias(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInstituto formPrincipal = new FormInstituto();
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormInstituto formInstituto = new FormInstituto();
            formInstituto.Show(); // Muestra el formulario FormInstituto
            this.Close(); // Cierra el formulario actual (FormProfe)
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            LlenarNuevoDGV();
        }

        private void LlenarNuevoDGV()
        {
            AdministracionProfesor objProf = new AdministracionProfesor();

            // Obtener los datos de materias y profesores
            DataSet dsMaterias = listadoMaterias.LisMaterias("Todos");
            DataSet dsProfesores = objProf.listadoProf("todos");

            // Crear un nuevo DataTable para los datos combinados
            dtCombinado.Columns.Add("Codigo Materia", typeof(string));
            dtCombinado.Columns.Add("Materia", typeof(string)); // Cambiar el nombre de la columna
            dtCombinado.Columns.Add("Legajo Profesor", typeof(string));
            dtCombinado.Columns.Add("DNI Profesor", typeof(string));
            dtCombinado.Columns.Add("Nombres Profesor", typeof(string));
            dtCombinado.Columns.Add("Apellidos Profesor", typeof(string));
            dtCombinado.Columns.Add("Estado Materia", typeof(string));

            // Combinar los datos de profesores y materias en el DataTable combinado
            foreach (DataRow materiaRow in dsMaterias.Tables[0].Rows)
            {
                string legajoProfesorMateria = materiaRow["LegajoProfesor"].ToString();
                bool profesorEncontrado = false;

                // Buscar el profesor correspondiente en el DataSet de profesores
                foreach (DataRow profesorRow in dsProfesores.Tables[0].Rows)
                {
                    string legajoProfesorProfesor = profesorRow["Legajo"].ToString();
                    if (legajoProfesorMateria == legajoProfesorProfesor)
                    {
                        // Se ha encontrado el profesor, combina los datos

                        // Cambiar "true" a "activa" e "false" a "inactiva"
                        string estado = materiaRow["Estado"].ToString();
                        if (estado == "True")
                        {
                            estado = "activa";
                        }
                        else if (estado == "False")
                        {
                            estado = "inactiva";
                        }

                        dtCombinado.Rows.Add(
                            materiaRow["Codigo"],
                            materiaRow["Nombre"],
                            legajoProfesorProfesor,
                            profesorRow["Dni"],
                            profesorRow["Nombres"],
                            profesorRow["Apellidos"],
                            estado
                        );

                        profesorEncontrado = true;
                        break;
                    }
                }

                // Si no se encontró un profesor correspondiente, coloca "Profesor no cargado"
                if (!profesorEncontrado)
                {
                    // Cambiar "true" a "activa" e "false" a "inactiva"
                    string estado = materiaRow["Estado"].ToString();
                    if (estado == "True")
                    {
                        estado = "activa";
                    }
                    else if (estado == "False")
                    {
                        estado = "inactiva";
                    }

                    dtCombinado.Rows.Add(
                        materiaRow["Codigo"],
                        materiaRow["Nombre"],
                        legajoProfesorMateria,
                        "Profesor no cargado",
                        "Profesor no cargado",
                        "Profesor no cargado",
                        estado
                    );
                }
            }

            // Mostrar los datos combinados en el DataGridView
            dataGridView1.DataSource = dtCombinado;
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dtCombinado.Rows.Count == 0)
            {
                MessageBox.Show("Debe traer los datos primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Ajustar automáticamente el ancho de las columnas
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Crea una instancia de PrintDocument
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += new PrintPageEventHandler(PrintPage);

                // Configura el cuadro de diálogo de impresión
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = doc;

                // Muestra el cuadro de diálogo de vista previa de impresión
                currentRow = 0; // Restablece la posición de impresión
                printPreviewDialog.ShowDialog();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            DataGridView dataGridView = dataGridView1;
            DataGridViewRow row;

            Font font = new Font("Arial", 8);
            float margin = 40;
            float y = margin;
            float lineOffset = font.GetHeight() + 10;
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black); // Línea negra

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView.Columns[i].HeaderText, font, brush, margin + (i * 120), y);
            }

            y += lineOffset;

            // Dibujar una línea negra debajo de los títulos de las columnas
            e.Graphics.DrawLine(pen, margin, y, e.MarginBounds.Right, y);
            y += 5; // Espacio adicional después de la línea

            while (currentRow < dataGridView.Rows.Count)
            {
                row = dataGridView.Rows[currentRow];
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    e.Graphics.DrawString(row.Cells[i].Value.ToString(), font, brush, margin + (i * 120), y);
                }
                y += lineOffset;
                currentRow++;

                if (y + lineOffset > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }
    }
}
