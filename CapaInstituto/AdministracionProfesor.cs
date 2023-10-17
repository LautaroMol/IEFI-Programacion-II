using Entidades.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaInstituto
{
    public class AdministracionProfesor : DatosdeConexion
    {
        public int abmProfesores(string accion, Profesor objProfesor)
        {
            int result = -1; // Controlamos que se realice la operación
            string orden = string.Empty; // Guardamos la consulta

            if (accion == "Alta")
            {
                orden = "insert into Profesores values (" + objProfesor.getLeg() + ","
                    + objProfesor.getDni() + ",'" + objProfesor.getNom() + "','" + objProfesor.getAp() + "',"
                    + objProfesor.getEd() + "," + objProfesor.getLib() + ");";
            }

            if (accion == "Modificar")
            {
                orden = "update Profesores SET Dni = '" + objProfesor.getDni() + "', Nombre = '"
                    + objProfesor.getNom() + "', Apellido = '" + objProfesor.getAp() + "', Edad = "
                    + objProfesor.getEd() + ", Libre = " + (objProfesor.getLib() ? 1 : 0) + " WHERE Legajo = "
                    + objProfesor.getLeg() + ";";
            }

            if (accion == "Borrar")
            {
                orden = "delete from Profesores WHERE Legajo = " + objProfesor.getLeg();
            }

            // Aquí deberías ejecutar la consulta SQL y manejar el resultado según tu entorno de desarrollo.

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                result = cmd.ExecuteNonQuery(); 
            }catch (Exception ex) { throw new Exception("Error al tratar de operar con los alumnos", ex); }
            finally { Cerrarconexion(); cmd.Dispose(); }
            return result;  
        }
        public DataSet listadoProf(string leg)
        {
            string orden = string.Empty;
            if (leg != "todos")
                orden = "select * from Profesores where Legajo = " + leg.ToString() + ";";
            else orden = "select * from Profesores;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Profesores", e);
            }
            finally
            {
                Cerrarconexion(); cmd.Dispose();
            }
            return ds;
        }

    }
}
