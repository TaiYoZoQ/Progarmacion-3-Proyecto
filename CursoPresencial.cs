using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    class CursoPresencial : Evento
    {
        int Aula;
        static double DescuentoPorSocio = 1-0.3;

        public CursoPresencial(string nombre, double costo, int aula) : base(nombre,costo)
        {
            Aula = aula;
        }


        public override double Recaudado()
        {           
            double recaudado = 0;

            foreach(Alumno alu in Inscriptos)
            {
                if (alu.Socio)
                    recaudado += Costo * DescuentoPorSocio;
                else
                    recaudado += Costo;
            }

            return recaudado;
        }

    }
}
