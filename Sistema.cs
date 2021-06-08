using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{
    [Serializable]
    public class Sistema
    {
        public List<Alumno> Alumnos;
        public Dictionary<int, Evento> Eventos;

        public Sistema()
        {
            Alumnos = new List<Alumno>();
            Eventos = new Dictionary<int, Evento>();
        }

        public  void AgregarAlumno(Alumno alumnoNuevo)
        {
            Alumnos.Add(alumnoNuevo);
        }        

        public  void AgregarEvento(Evento eventoNuevo)
        {
            int id = Eventos.Count+1;
            Eventos.Add(id,eventoNuevo);
        }        

        public  void InscribirAEvento(int AlumnoId,int EventoId)
        {
            BuscarAlumnoPorID(AlumnoId).inscribir(BuscarEventoPorId(EventoId));
            BuscarEventoPorId(EventoId).AgregarAlumno(BuscarAlumnoPorID(AlumnoId));
        }


        public  Alumno BuscarAlumnoPorID(int id)
        {
            foreach(Alumno alumno in Alumnos)
            {
                if (alumno.Id == id)
                {
                    return alumno;
                }               
                
            }
            throw new AlumnoInexistente();
        }

        public  Evento BuscarEventoPorId(int id)
        {
            foreach (KeyValuePair<int, Evento> evento in Eventos)
            {
                if (evento.Key == id)
                {
                    return evento.Value;
                }

            }
            throw new Exception();
        }
    }
}
