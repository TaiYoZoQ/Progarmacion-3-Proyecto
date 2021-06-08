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
        private List<Alumno> Alumnos;
        private double RecaudoTotal;
        private Sistema sistema;

        public Tesoreria(Form Principal, Sistema sis)
        {
            Alumnos = sis.Alumnos;
            sistema = sis;
            FrmPrincipal = Principal;
            InitializeComponent();
            CompletarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }
       
        private void CompletarDatos()
        {
            TbRecaudadoTotal.Text = "";            
            RecaudoTotal = 0;
            double Recaudado;

            foreach (Alumno alumno in Alumnos)
            {
                string AlumnoMasAbono = "";
                Recaudado = alumno.CuantoAbona();
                AlumnoMasAbono += alumno.Nombre + " _ ";
                AlumnoMasAbono += Convert.ToString(Recaudado);
                LbListadoAlumnos.Items.Add(AlumnoMasAbono);
                RecaudoTotal += Recaudado;
            }
            TbRecaudadoTotal.Text = Convert.ToString(RecaudoTotal);
        }
    }
}
