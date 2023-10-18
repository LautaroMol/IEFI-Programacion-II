using CapaInstituto;
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

namespace IEFI_Programación_II.FormProfesor
{

    public partial class FormProfe : Form
    {
        List<Profesor> listaprof = new List<Profesor>();
        AdministracionProfesor objProf = new AdministracionProfesor();

        public FormProfe()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Legajo", "Legajo");
            dataGridView1.Columns.Add("Dni", "Dni");
            dataGridView1.Columns.Add("Nombres", "Nombres");
            dataGridView1.Columns.Add("Apellidos", "Apellidos");
            dataGridView1.Columns.Add("Libre", "Libre");
            dataGridView1.Columns.Add("Edad", "Edad");
        }

        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objProf.listadoProf("todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecnac = dateTimePicker1.Value;
            DateTime Fecha = DateTime.Now;
            if (fecnac > Fecha)
            {
                MessageBox.Show("la fecha de nacimiento es mayor a la actual");
            }
            else
            {
                if (txtleg.Text != "" && txtDni.Text != "" && txtNom.Text != "" && txtAp.Text != "")
                {
                    Profesor profEnc = null;
                    foreach (Profesor prof in listaprof)
                    {
                        if (prof.getLeg().ToString() == txtDni.Text)
                        {
                            profEnc = prof;
                            break;
                        }

                    }
                    if (profEnc != null) { MessageBox.Show("el profesor ya esta cargado"); }
                    else
                    {
                        Profesor profesor = new Profesor(int.Parse(txtleg.Text), int.Parse(txtDni.Text), txtNom.Text.ToString(),
                            txtAp.Text.ToString(), checkBox1.Checked, dateTimePicker1.Value);
                        listaprof.Add(profesor);
                        dataGridView1.Rows.Add(txtleg.Text, txtDni.Text, txtNom.Text, txtAp.Text, checkBox1.Checked, profesor.getEd());
                        MessageBox.Show("profesor guardado");
                    }
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DateTime fecnac = dateTimePicker1.Value;
            DateTime Fecha = DateTime.Now;
            if (fecnac > Fecha)
            {
                MessageBox.Show("la fecha de nacimiento es mayor a la actual");
            }
            else
            {
                if (txtleg.Text != "" && txtDni.Text != "" && txtNom.Text != "" && txtAp.Text != "")
                {
                    DataSet ds = new DataSet();
                    ds = objProf.listadoProf("todos");
                    DataRow profEnc = null;
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (dr[0].ToString() == txtleg.Text || dr[1].ToString() == txtDni.Text)
                            {
                                profEnc = dr;
                                break;
                            }
                        }
                    }
                    if (profEnc != null) { MessageBox.Show("ya hay un profesor con ese legajo o dni"); }
                    else
                    {
                        int nGrabados = -1;
                        Profesor nuevoProf = new Profesor(int.Parse(txtleg.Text), int.Parse(txtDni.Text), txtNom.Text.ToString(),
                        txtAp.Text.ToString(), checkBox1.Checked, dateTimePicker1.Value);
                        nGrabados = objProf.abmProfesores("Alta", nuevoProf);
                        if (nGrabados == -1) { MessageBox.Show("No se pudo guardar el profesor"); }
                        else { MessageBox.Show("Profesor guardado"); }
                    }
                }
            }
        }

        private void btnllenar_Click(object sender, EventArgs e)
        {
            LlenarDGV();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un profesor para borrar.");
                return;
            }

            int legajoSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Legajo"].Value);

            // Eliminar el profesor de la base de datos
            int resultadoEliminacion = objProf.abmProfesores("Borrar", new Profesor(legajoSeleccionado, 0, "", "", false, DateTime.Now));

            if (resultadoEliminacion == -1)
            {
                MessageBox.Show("No se pudo borrar el profesor de la base de datos.");
            }
            else
            {
                // Actualizar el DataGridView después de la eliminación
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                MessageBox.Show("Profesor borrado de la base de datos.");
            }
            LlenarDGV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool band = false;
            DataSet ds = objProf.listadoProf("todos");

            if (txtMod.Text!=""&& txtDni.Text!="" && txtNom.Text!="" && txtAp.Text!="" && txtleg.Text == "")
            {
                Profesor profMod = new Profesor(int.Parse(txtMod.Text), int.Parse(txtDni.Text), txtNom.Text.ToString(),
                        txtAp.Text.ToString(), checkBox1.Checked, dateTimePicker1.Value);
                foreach (DataRow dr in ds.Tables[0].Rows) 
                {
                    if (dr[0].ToString() == txtMod.Text)
                    {
                        int est = objProf.abmProfesores("Modificar", profMod);
                        MessageBox.Show("Profesor de legajo: " + profMod.getLeg() + " modificado");
                        band = true;
                    }
                }
                if (!band) { MessageBox.Show("no se encontro al profesor"); }
            }
            else { MessageBox.Show("use el formato correcto, llene el campo de abajo y el resto de campos"); }
        }
    }
}
