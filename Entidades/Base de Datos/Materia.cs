using System;
using System.Collections.Generic;
using System.Linq;
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
        public string PNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }


        public int PLegajoProfesor
        {
            get { return LegajoProfesor; }
        }
        public int PCodigo
        {
            get { return Codigo; }
        }
        public bool PEstado
        {
            set { Estado = value; }
            get { return Estado; }
        }


        #endregion

        #region Constructores

        public Materia()
        {

        }

        public Materia(int cod, string nombre, int legajoprof)
        {
            this.Nombre = nombre;
            this.LegajoProfesor = legajoprof;
            this.Codigo = cod;
            Estado = true;
        }
        #endregion

        #region Métodos
        public string DarDatos()
    {
        string datos = $"Código: {Codigo}\n";
        datos += $"Nombre: {Nombre}\n";
        datos += $"Legajo del Profesor: {LegajoProfesor}\n";
        datos += $"Estado: {(Estado ? "Activa" : "Inactiva")}";
        return datos;
    }


    #endregion
}

}