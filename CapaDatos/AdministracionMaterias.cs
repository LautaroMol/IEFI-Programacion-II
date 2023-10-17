using Entidades.Base_de_Datos;
using System;
using System.Data;
using System.Data.OleDb;


//namespace CapaDatos
//{
//    public class AdministracionMaterias : DatosdeConexion
//    {
//        public int abmMaterias(string accion, Materia objMateria)
//        {
//            int result = -1; // Inicializamos result en -1 para controlar la operación

//            // Definimos una cadena para almacenar la consulta SQL
//            string query = string.Empty;

//            try
//            {
//                using (OleDbConnection conn = new OleDbConnection(conexion))
//                using (OleDbCommand cmd = new OleDbCommand())
//                {
//                    conn.Open();
//                    cmd.Connection = conn;

//                    // Verificamos la acción y construimos la consulta SQL correspondiente
//                    if (accion == "Alta")
//                    {
//                        query = "INSERT INTO Materias (Nombre, LegajoProfesor, Estado) VALUES (?, ?, ?)";
//                    }
//                    else if (accion == "Modificar")
//                    {
//                        query = "UPDATE Materias SET Nombre = ?, LegajoProfesor = ?, Estado = ? WHERE Codigo = ?";
//                    }
//                    else if (accion == "Borrar")
//                    {
//                        query = "DELETE FROM Materias WHERE Codigo = ?";
//                    }

//                    // Asignamos la consulta SQL al comando y configuramos los parámetros
//                    cmd.CommandText = query;
//                    cmd.Parameters.AddWithValue("@Nombre", objMateria.PNombre);
//                    cmd.Parameters.AddWithValue("@LegajoProfesor", objMateria.PLegajoProfesor);
//                    cmd.Parameters.AddWithValue("@Estado", objMateria.PEstado);

//                    // Si es una modificación o eliminación, agregamos el parámetro de Código
//                    if (accion == "Modificar" || accion == "Borrar")
//                    {
//                        cmd.Parameters.AddWithValue("@Codigo", objMateria.PCodigo);
//                    }

//                    // Ejecutamos la consulta y guardamos el resultado
//                    result = cmd.ExecuteNonQuery();
//                }
//            }
//            catch (Exception ex)
//            {
//                // Manejo de errores: lanzamos una excepción con un mensaje descriptivo
//                throw new Exception("Error al operar con las materias", ex);
//            }

//            return result; // Devolvemos el resultado de la operación
//        }

//        public DataSet listadoMaterias(string codigo)
//        {
//            string query = string.Empty;

//            if (codigo != "todos")
//            {
//                query = "SELECT * FROM Materias WHERE Codigo = ?";
//            }
//            else
//            {
//                query = "SELECT * FROM Materias";
//            }

//            DataSet ds = new DataSet();

//            try
//            {
//                using (OleDbConnection conn = new OleDbConnection(conexion))
//                using (OleDbCommand cmd = new OleDbCommand(query, conn))
//                using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
//                {
//                    if (codigo != "todos")
//                    {
//                        cmd.Parameters.AddWithValue("@Codigo", codigo);
//                    }

//                    conn.Open();
//                    da.Fill(ds);
//                }
//            }
//            catch (Exception e)
//            {
//                throw new Exception("Error al listar Materias", e);
//            }

//            return ds; // Devolvemos el conjunto de datos resultante
//        }
//    }
//}