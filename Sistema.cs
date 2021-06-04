using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Prog_3
{    
    static class Sistema
    {
        private static List<Alumno> Alumnos = new List<Alumno>();
        private static Dictionary<int, Evento> Eventos = new Dictionary<int, Evento>();

        //Esta es la forma que encontré para pasar las colecciones a los formularios, no se si es lo mejor
        public static Dictionary<int, Evento> DictionaryEventos                                             
        {
            get
            {
                return Eventos;
            }
        }

        public static List<Alumno> DictionaryAlumnos
        {
            get
            {
                return Alumnos;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hay dos funciones agregar alumno, una de sistema y otra de evento.
        public static void AgregarAlumno(Alumno alumnoNuevo)
        {
            Alumnos.Add(alumnoNuevo);
        }        

        public static void AgregarEvento(Evento eventoNuevo)
        {
            int id = Eventos.Count+1;
            Eventos.Add(id,eventoNuevo);
        }        

        public static void InscribirAEvento(int AlumnoId,int EventoId)
        {
            BuscarAlumnoPorID(AlumnoId).inscribir(BuscarEventoPorId(EventoId));
            BuscarEventoPorId(EventoId).AgregarAlumno(BuscarAlumnoPorID(AlumnoId));
        }


        public static Alumno BuscarAlumnoPorID(int id)
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

        public static Evento BuscarEventoPorId(int id)
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
