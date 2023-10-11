using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Base_de_Datos
{
    public class Profesor
    {
        private int Legajo;
        private int Dni;
        private string Nombres;
        private string Apellidos;
        private bool Libre;
        //Constructores

        public Profesor() { }

        public Profesor(int legajo, int dni, string nombres, string apellidos, bool libre, DateTime fecnac)
        {
            this.Legajo = legajo;
            this.Dni = dni;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Libre = libre;
            DateTime fecha = DateTime.Now;
            int edad = fecha.Year - fecnac.Year;
            if (fecnac.Month > fecha.Month) { --edad; }
        }


        #region Propiedades
        public string PNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public string PApellido
        {
            set { Apellido = value; }
            get { return Apellido; }
        }

        public int PLegajo
        {
            get { return Legajo; }
        }
        public int PDni
        {
            get { return Dni; }
        }
        public bool PLibre
        {
            set { Libre = value; }
            get { return Libre; }
        }

        public DateTime PFechaNamiciento
        {
            get { return FechaNacimiento; }
        }

        #endregion

        #region Constructores

        public Profesor()
        {
            
        }

        public Profesor(int leg, string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            Dni = dni;
            Libre = true;
            FechaNacimiento = DateTime.MinValue;
            this.Legajo = leg;
        }
        #endregion

        #region Metodos
      
        #endregion

    }
}

