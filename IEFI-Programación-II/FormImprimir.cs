using CapaInstituto;
using System.Data;
using System.Drawing.Printing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Security.Policy;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        } catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("no pudo guardarse el archivo");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("archivo guardado exitosamente", "Info");
                        }
                        catch (Exception ex) { MessageBox.Show("error: " + ex.Message); } }
                }
            }
        }
    }
}
