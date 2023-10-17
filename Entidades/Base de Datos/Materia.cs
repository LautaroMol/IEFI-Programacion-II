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

        #region Constructores
        public Materia() { }

        public Materia(int cod, string nombre, int legajoprof)
        {
            this.Codigo = cod;
            this.Nombre = nombre;
            this.LegajoProfesor = legajoprof;
            this.Estado = true;
        }
        #endregion

        #region Métodos

        public void EstablecerNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return this.Nombre;
        }

        public int ObtenerLegajoProfesor()
        {
            return this.LegajoProfesor;
        }

        public int ObtenerCodigo()
        {
            return this.Codigo;
        }

        public void EstablecerEstado(bool estado)
        {
            this.Estado = estado;
        }

        public bool ObtenerEstado()
        {
            return this.Estado;
        }

        public string DarDatos()
        {
            string datos = $"Código: {ObtenerCodigo()}\n";
            datos += $"Nombre: {ObtenerNombre()}\n";
            datos += $"Legajo del Profesor: {ObtenerLegajoProfesor()}\n";
            datos += $"Estado: {(ObtenerEstado() ? "Activa" : "Inactiva")}";
            return datos;
        }
        #endregion
    }
}
