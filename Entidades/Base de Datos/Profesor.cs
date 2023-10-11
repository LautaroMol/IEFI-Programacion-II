using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private int Edad;
        //Constructores

        public Profesor() { }

        public Profesor(int Legajo, int Dni, string Nombres, string Apellidos, bool Libre, DateTime fecnac)
        {
            this.Legajo = Legajo;
            this.Dni = Dni;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Libre = Libre;
            DateTime fecha = DateTime.Now;
            Edad = fecha.Year - fecnac.Year;
            if (fecnac.Month > fecha.Month) { --Edad; }
        }

        public Profesor(int Legajo, int Dni, string Nombres, string Apellidos, bool Libre, int edad)
        {
            this.Legajo = Legajo;
            this.Dni = Dni;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Libre = Libre;
            Edad = edad;
        }

        public void Agregar(int legajo, int dni, string nombres, string apellidos, bool libre, DateTime fecnac)
        {
            Legajo = legajo;
            Dni = dni;
            Nombres = nombres;
            Apellidos = apellidos;
            Libre = libre;
            DateTime fecha = DateTime.Now;
            Edad = fecnac.Year - fecha.Year;
            if (fecnac.Month > fecha.Month) { --Edad; }
        }

        //gets
        public int getLeg()
        {
            return this.Legajo;
        }

        public int getDni() { return this.Dni; }
        public string getNom() { return this.Nombres; }
        public string getAp() { return this.Apellidos; }
        public int getEd() { return this.Edad; }
        public bool getLib() { return this.Libre; }
        public string DarDatos()
        {
            string datos = $"DNI: {Dni}\n";
            datos += $"Nombre: {Nombres}\n";
            datos += $"Apellido: {Apellidos}\n";
            datos += $"Edad: {Edad}\n";
            datos += $"Esta activo?: {(Libre ? "Activo" : "Inactivo")}";

            return datos;
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

