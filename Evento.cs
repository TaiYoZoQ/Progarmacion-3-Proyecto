using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    abstract class Evento
    {
        protected string Nombre;
        public double Costo;
        public double DescuentoSocio = 1 - 0.15;
        protected List<Alumno> Inscriptos;
        

        public Evento(string nombre, double costo)
        {
            Nombre = nombre;
            Costo = costo;
            Inscriptos = new List<Alumno>();
        }
        
        public string GetNombre()
        {            
            string nombreCompleto = Convert.ToString(this.GetType()) + "__" + Nombre;
            nombreCompleto = nombreCompleto.Remove(0, 16);
            return nombreCompleto;
        }
        


        public void AgregarAlumno(Alumno alumno)
        {
            Inscriptos.Add(alumno);
        }


        public abstract double Recaudado();

    }
}
