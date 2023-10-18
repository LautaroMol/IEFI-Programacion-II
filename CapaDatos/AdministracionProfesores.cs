using Entidades.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class AdministracionProfesores : DatosdeConexion
    {
        public int abmProfesores(string accion, Profesor objProfesor)
        {
            int result = -1; // Controlamos que se realice la operación
            string orden = string.Empty; // Guardamos la consulta

            if (accion == "Alta")
            {
                orden = "insert into Profesores values (" + objProfesor.getLeg() + ","
                    + objProfesor.getDni() + ",'" + objProfesor.getNom() + "','" + objProfesor.getAp() + "',"
                    + objProfesor.getLib() + "," + objProfesor.getEd() + ");";
            }

            if (accion == "Modificar")
            {
                orden = "update Profesores SET Nombres = '" + objProfesor.getNom() + "', Apellidos = '"
                + objProfesor.getAp() + "', Edad = " + objProfesor.getEd() + ", Libre = " +
                objProfesor.getLib() + " WHERE Legajo = " + objProfesor.getLeg() + ";";
            }

            if (accion == "Borrar")
            {
                orden = "delete from Profesores WHERE Legajo = " + objProfesor.getLeg();
            }

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception("Error al tratar de operar con los Profesores", ex); }
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
