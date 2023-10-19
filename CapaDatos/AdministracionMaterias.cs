using Entidades.Base_de_Datos;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace CapaDatos
{
    public class AdministracionMaterias : DatosdeConexion
    {
        // Método para realizar operaciones de alta, baja y modificación en la base de datos.
        public int abmMaterias(string accion, Materia objMateria)
        {
            int resultado = -1; // Iniciamos resultado en -1 para controlar la operación.
            string query = string.Empty; // Se define la cadena para almacenar la consulta.

            try
            {
                // Conexión con la base de datos
                OleDbConnection conn = new OleDbConnection(conexion.ToString());
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    conn.Open(); // Se abre la conexión a la base de datos
                    cmd.Connection = conn;

                    // Verifica las acciones y consultas.
                    if (accion == "Alta")
                    {
                        query = "INSERT INTO Materias (Nombre, Apellido, LegajoProfesor, Estado) VALUES (?, ?, ?, ?)";
                    }
                    else if (accion == "Borrar")
                    {
                        query = "DELETE FROM Materias WHERE Codigo = ?";
                    }
                    else if (accion == "Modificar")
                    {
                        query = "UPDATE Materias SET Nombre = ?, Apellido = ?, LegajoProfesor = ?, Estado = ? WHERE Codigo = ?";
                    }
                   

                    // Asignamos la consulta SQL al comando y configuramos los parámetros
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Nombre", objMateria.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", objMateria.Apellido);
                    cmd.Parameters.AddWithValue("@LegajoProfesor", objMateria.LegajoProfesor);
                    cmd.Parameters.AddWithValue("@Estado", objMateria.Estado);

                    // Si es una modificación o eliminación, agregamos el parámetro de Codigo
                    if (accion == "Modificar" || accion == "Borrar")
                    {
                        cmd.Parameters.AddWithValue("@Codigo", objMateria.Codigo);
                    }

                    // Ejecuta la consulta y guardamos el resultado
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores: lanzamos una excepción con un mensaje
                throw new Exception("Error al operar con las materias", ex);
            }

            return resultado; // Devuelve el resultado de la operación
        }

        // Método para obtener un conjunto de datos de materias según el filtro especificado.
        public DataSet listadoMat(int codigo)
        {
            string query = string.Empty;

            if (codigo == -1)
            {
                query = "SELECT * FROM Materias";
            }
            else
            {
                query = "SELECT * FROM Materias WHERE Codigo = ?";
            }

            DataSet ds = new DataSet();

            try
            {
                // Establecemos una conexión con la base de datos
                using (OleDbConnection conn = new OleDbConnection(conexion.ToString()))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                {
                    if (codigo != -1)
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                    }

                    conn.Open(); // Abrimos la conexión a la base de datos
                    da.Fill(ds);  // Rellenamos el conjunto de datos con los resultados de la consulta
                }
            }
            catch (Exception e)
            {
                // Manejo de errores: lanzamos una excepción con un mensaje
                throw new Exception("Error al listar Materias", e);
            }

            return ds; // Devolvemos el conjunto de datos resultante
        }
    }
}