using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Prog_3
{
    public partial class Alumnos : Form
    {
        private Form FrmPrincipal;
        private Alumno alumnoAux;
        private Dictionary<int, Evento> Eventos = Sistema.DictionaryEventos;

        public Alumnos(Form Principal)
        {
            FrmPrincipal = Principal;
            InitializeComponent();

        }

        //Con esto busco un alumno y completo los datos del formulario
        private void Buscar_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(TbId.Text))
            {
                //1.Acá intento traer un alumno y lo guardo en una variable local para mostrar los datos
                //2.Paso a Enable los elementos que estaban deshabilitados                
                //3.Pongo los nombres de cada evento en una Combobox
                //4.Si no se encontró ningún alumno, doy mensajes de error
                try
                {
                    //1
                    alumnoAux = Sistema.BuscarAlumnoPorID(int.Parse(TbId.Text));
                    TbNombre.Text = alumnoAux.Nombre;
                    //2
                    if (alumnoAux.Socio)
                        CbEsSocio.Checked = true;
                    CbEventos.Enabled = true;
                    Inscribir.Enabled = true;
                    BtnVerEventos.Enabled = true;

                    //3
                    foreach(KeyValuePair<int, Evento> evento in Eventos)
                    {
                        CbEventos.Items.Add(evento.Value.GetNombre());                        
                    }
                //4
                }
                catch (AlumnoInexistente)
                {
                    MessageBox.Show("El Alumno no existe");
                }
            }
            else
                MessageBox.Show("Debe ingresar una ID");

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void Inscribir_Click(object sender, EventArgs e)
        {
            Sistema.InscribirAEvento(alumnoAux.Id, CbEventos.SelectedIndex+1);
            MessageBox.Show("Alumno Inscripto");
        }

        private void BtnVerEventos_Click(object sender, EventArgs e)
        {
            string mensaje ="";
            foreach (KeyValuePair<int, Evento> evento in alumnoAux.Eventos)
            {
                if (evento.Key > 1)
                    mensaje += ", ";
                mensaje += evento.Value.GetNombre()+" ";
            }
            MessageBox.Show(mensaje);
        }
    }
}
