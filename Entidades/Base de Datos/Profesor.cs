using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Base_de_Datos
{
    public class Profesor
    {
        #region Atributos
        private int Legajo;
        private int Dni;
        private bool Libre;
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
   
     
        #endregion

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

