using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Prog_3
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            //var sistema = new Sistema();
            var CursoOn = new CursoOnline("Php", 3500, 0.3);
            var CursoPe = new CursoPresencial("Java", 5000, 4);
            var Charla = new Charla("Desarrollo Full Stack", 800, "Jorge Argibay");
            var alumno = new Alumno("Pablo Maggiolo", 1, true);

            Sistema.AgregarEvento(CursoOn);
            Sistema.AgregarEvento(CursoPe);
            Sistema.AgregarEvento(Charla);
            Sistema.AgregarAlumno(alumno);
            Sistema.InscribirAEvento(1, 2);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioPrincipal());

            /*
            NuevoEvento(sistema);
            
                Stream flujo = File.Create("Sys.bin");
                BinaryFormatter serializador = new BinaryFormatter();
                serializador.Serialize(flujo, sistema);
                flujo.Close();

            sistema.AgregarEvento();
            */

        }

    }
}
