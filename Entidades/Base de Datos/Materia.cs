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
        private int Codigo;
        private int LegajoProfesor;
        private bool Estado;
        private string Nombre;
        #endregion

        #region Propiedades
        public int Pcodigo
        {
            set { Codigo = value; }
            get { return Codigo; }
        }
        public int Plegajo
        {
            set { LegajoProfesor = value; }
            get { return LegajoProfesor; }
        }
        public bool Pestado
        {
            set { Estado = value; }
            get { return Estado; }
        }
        public string Pnombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        #endregion

        #region Constructores
        public Materia() { }

        public Materia(int cod, int legprofesor, bool estado, string nom)
        {
            Codigo = cod;
            LegajoProfesor = legprofesor;
            Estado = estado;
            Nombre = nom;
        }


        public void Agregar(int cod, int legprofesor, bool estado, string nom)
        {
            Codigo = cod;
            LegajoProfesor = legprofesor;
            Estado = estado;
            Nombre = nom;
        }
        #endregion

        #region Métodos
        // Esta entidad por el momento no contiene métodos. 
        #endregion

    }

}