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
    public class AdministracionProfesor
    {
        AdministracionProfesores DatosProfesores = new AdministracionProfesores();

        public int abmProfesores(string accion, Profesor objprofesor)
        {
            return DatosProfesores.abmProfesores(accion, objprofesor);
        }  
        public DataSet listadoProf(string leg)
        {
            return DatosProfesores.listadoProf(leg);
        }
    }
}
