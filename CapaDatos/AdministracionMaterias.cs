using Entidades.Base_de_Datos;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace CapaDatos
{
    public class AdministracionMaterias : DatosdeConexion
    {
        // Constructor que recibe la cadena de conexión
        public AdministracionMaterias(string connectionString)
        {
            this.conexion.ConnectionString = connectionString;
        }

        // Método para realizar operaciones de alta, baja y modificación en la base de datos
        public int AbmMaterias(string accion, Materia objMateria)
        {
            int resultado = -1;
            string consulta = string.Empty;

            if (accion == "Agregar")
            {
                // Consulta para agregar una nueva materia a la base de datos
                consulta = "INSERT INTO Materia (Codigo, LegajoProfesor, Nombre, Estado) " +
                           "VALUES (?, ?, ?, ?)";
            }
            else if (accion == "Borrar")
            {
                // Consulta para borrar una materia de la base de datos
                consulta = "DELETE FROM Materia WHERE Codigo = ?";
            }
            else if (accion == "Modificar")
            {
                // Consulta para modificar una materia existente en la base de datos
                consulta = "UPDATE Materia SET " +
                           "LegajoProfesor = ?, " +
                           "Nombre = ?, " +
                           "Estado = ? " +
                           "WHERE Codigo = ?";
            }

            // Prepara la consulta con parámetros y realiza la operación en la base de datos
            using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("param1", objMateria.Pcodigo);
                cmd.Parameters.AddWithValue("param2", objMateria.Plegajo);
                cmd.Parameters.AddWithValue("param3", objMateria.Pnombre);
                cmd.Parameters.AddWithValue("param4", objMateria.Pestado ? 1 : 0); // 1 para verdadero (activo), 0 para falso (inactivo)

                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery(); // Ejecuta la consulta y devuelve la cantidad de filas afectadas
                }
                catch (Exception error)
                {
                    throw new Exception("Error al tratar de agregar, modificar o borrar materias", error);
                }
            }

            return resultado; // Devuelve el resultado de la operación
        }
        // Método para actualizar el legajo de una materia en la base de datos
        public int ActualizarLegajoEnBaseDeDatos(int codigo, int nuevoLegajo)
        {
            int resultado = -1;
            string consulta = "UPDATE Materia SET LegajoProfesor = ? WHERE Codigo = ?";

            // Prepara la consulta con parámetros y actualiza el legajo en la base de datos
            using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("param1", nuevoLegajo);
                cmd.Parameters.AddWithValue("param2", codigo);

                try
                {
                    Abrirconexion();
                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    throw new Exception("Error al actualizar el legajo en la base de datos", error);
                }
            }

            return resultado;
        }
        // Obtiene un conjunto de datos de las materias según el filtro especificado
        public DataSet LisMaterias(string cual)
        {
            string consulta = string.Empty;

            if (cual != "Todos")
            {
                consulta = "SELECT * FROM Materia WHERE Codigo = ?";
            }
            else
            {
                consulta = "SELECT * FROM Materia";
            }
            // Prepara la consulta con parámetros y devuelve un conjunto de datos
            using (OleDbCommand cmd = new OleDbCommand(consulta, conexion))
            {
                if (cual != "Todos")
                {
                    cmd.Parameters.AddWithValue("param1", int.Parse(cual));
                }

                DataSet ds = new DataSet();

                OleDbDataAdapter da = new OleDbDataAdapter();

                try
                {
                    Abrirconexion();
                    da.SelectCommand = cmd;
                    da.Fill(ds); // Rellena el DataSet con los datos obtenidos
                }
                catch (Exception error)
                {
                    throw new Exception("Error al listar materias", error);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }

                return ds; // Devuelve el conjunto de datos
            }

        }

    }
}