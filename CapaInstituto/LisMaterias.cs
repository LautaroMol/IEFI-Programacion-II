using Entidades.Base_de_Datos;
using System.Data;
using CapaDatos;

namespace CapaInstituto
{
    public class LisMaterias
    {
        AdministracionMaterias DatosMaterias = new AdministracionMaterias();

        public int abmMaterias(string accion, Materia objMateria)
        {
            return DatosMaterias.abmMaterias(accion, objMateria);
        }

        public DataSet listadoMat(int codigo)
        {
            return DatosMaterias.listadoMat(codigo);
        }
    }
}
