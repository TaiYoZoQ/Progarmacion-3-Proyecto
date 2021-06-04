using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    class CursoOnline : Evento
    {
        public double Comision = 0;

        public CursoOnline(string nombre, double costo, double comision) : base(nombre, costo)
        {
            Comision = 1-comision;
        }


        public override double Recaudado()
        {
            double recaudado = 0;
            foreach (Alumno alumno in Inscriptos)
            {
                if (alumno.Socio)
                    recaudado += Costo * DescuentoSocio;
                else
                    recaudado += Costo;

            }
            return recaudado*Comision;
        }
    }
}
