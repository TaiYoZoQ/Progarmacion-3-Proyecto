using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    [Serializable]
    public class Alumno
    {
        public int Id;
        public string Nombre;
        public bool Socio;
        public Dictionary<int, Evento> Eventos;
        private int CantidadDeEventos = 0;        

        public Alumno(string nombre, int id, bool socio)
        {
            Id = id;
            Nombre = nombre;
            Socio = socio;
            Eventos = new Dictionary<int, Evento>();
        }

        public void inscribir(Evento evento)
        {
            Eventos.Add(CantidadDeEventos+1,evento);
            CantidadDeEventos++;
        }

        
        public double CuantoAbona()
        {
            double Abonado = 0;
            if (Eventos.Count > 0)
            {
                foreach (KeyValuePair<int, Evento> evento in Eventos)
                {
                    if (evento.Value is Charla || !Socio)
                        Abonado += evento.Value.Costo;
                    else
                        Abonado += evento.Value.Costo * evento.Value.DescuentoSocio;
                }
            }
            return Abonado;
        }
        


    }
}
