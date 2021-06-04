using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Prog_3
{
    public partial class Tesoreria : Form
    {
        private Form FrmPrincipal;
        private List<Alumno> Alumnos = Sistema.DictionaryAlumnos;
        double RecaudoTotal = 0;

        public Tesoreria(Form Principal)
        {
            FrmPrincipal = Principal;
            InitializeComponent();
            string AlumnoMasAbono = "";
            double Recaudado = 0;

            foreach(Alumno alumno in Alumnos)
            {
                Recaudado = alumno.CuantoAbona();
                AlumnoMasAbono += alumno.Nombre+" _ ";                
                AlumnoMasAbono += Convert.ToString(Recaudado);
                LbListadoAlumnos.Items.Add(AlumnoMasAbono);
                RecaudoTotal += Recaudado;
            }
            TbRecaudadoTotal.Text = Convert.ToString(RecaudoTotal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }
       
    }
}
