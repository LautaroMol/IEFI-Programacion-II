using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosDeConexionL
    {
        protected OleDbConnection conexion;
        public string CadenadeConexionL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\Documentos\IEFI2.accdb""";


        public DatosDeConexionL()
        {
            conexion = new OleDbConnection(CadenadeConexionL);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();

            }
            catch (Exception error)
            {
                throw new Exception("Error al tratar de abrir la conexión", error);
            }

        }
        public void Cerrarconexion()

        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception error)
            {
                throw new Exception("Error al tratar de cerrar la conexión", error);
            }
        }
    }
}
