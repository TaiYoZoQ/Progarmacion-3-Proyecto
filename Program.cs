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
            var sistema = new Sistema();

            //Cargo Archivo de sistema
            if (File.Exists("Sys.bin"))
            {
                Stream flujo = File.OpenRead("Sys.bin");
                BinaryFormatter deserializador = new BinaryFormatter();
                sistema = (Sistema) deserializador.Deserialize(flujo);
                flujo.Close();
            }
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Le paso la variable sistema al primer formulario (ya sea "vacia" o cargada con los datos).
            Application.Run(new FormularioPrincipal(sistema));

            //Guardo Archivo de sistema actualizado
            Stream flujo2 = File.Create("Sys.bin");
            BinaryFormatter serializador = new BinaryFormatter();
            serializador.Serialize(flujo2, sistema);
            flujo2.Close();
            MessageBox.Show("Datos Guardados");



              
            


        }
    }
}
