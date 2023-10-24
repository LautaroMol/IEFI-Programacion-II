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

        // Este método se utiliza para realizar operaciones de alta, baja y modificación en la base de datos de materias.
        public int abmMaterias(string accion, Materia objmaterias)
        {
            return DatosMaterias.AbmMaterias(accion, objmaterias);
        }

        // Este método obtiene un conjunto de datos de las materias según el filtro especificado.
        public DataSet LisMaterias(string leg)
        {
            return DatosMaterias.LisMaterias(leg);
        }
    }
}
