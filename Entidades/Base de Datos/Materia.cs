using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace Entidades.Base_de_Datos
{
    public class Materia
    {
        #region Atributos
        private int codigo;
        private int legajoProfesor;
        private bool estado;
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int LegajoProfesor { get; set; }
        public bool Estado { get; set; }
        #endregion

        #region Constructores
        public Materia() { }

        public Materia(int cod, string nombres, int legajoprofes, string apellidos)
        {
            Codigo = cod;
            Nombre = nombres;
            LegajoProfesor = legajoprofes;
            Apellido = apellidos;
            Estado = true; // Por defecto, una materia se crea como activa
        }
        #endregion

        #region Métodos
        // Esta entidad se enfoca en representar la estructura de datos de una materia y no contiene lógica de negocio. Por eso no contiene métodos. 
        #endregion

    }

}