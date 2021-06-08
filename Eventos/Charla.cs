using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    [Serializable]
    class Charla : Evento
    {
        public string Orador;

        public Charla(string nombre, double costo, string orador) : base(nombre, costo)
        {
            Orador = orador;
        }        

        public override double Recaudado()
        {            
            return Inscriptos.Count*Costo;
        }
    }
}
