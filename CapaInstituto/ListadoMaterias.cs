using Entidades.Base_de_Datos;
using System.Data;
using CapaDatos;

namespace CapaInstituto
{
    public class ListadoMaterias
    {
        AdministracionMaterias DatosMaterias;

        public ListadoMaterias(string connectionString)
        {
            DatosMaterias = new AdministracionMaterias(connectionString);
        }

        public int abmMaterias(string accion, Materia objmaterias)
        {
            return DatosMaterias.AbmMaterias(accion, objmaterias);
        }

        public DataSet LisMaterias(string leg)
        {
            return DatosMaterias.LisMaterias(leg);
        }
    }
}
