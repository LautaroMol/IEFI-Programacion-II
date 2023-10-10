using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatosdeConexion
    {
        protected OleDbConnection conexion;
        public string CadenadeConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ibañez\Desktop\BDComputadora.accdb";


        public DatosdeConexion()
        {
            conexion = new OleDbConnection(CadenadeConexion);

        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
 ConnectionState.Closed)
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

