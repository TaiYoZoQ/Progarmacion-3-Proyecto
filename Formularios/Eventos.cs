using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Prog_3
{
    public partial class Eventos : Form
    {
        private Form FrmPrincipal;
        int tipoevento = 1; //Por default
        private Sistema sistema;

        public Eventos(Form Principal, Sistema sis)
        {
            sistema = sis;
            FrmPrincipal = Principal;
            InitializeComponent();

        }

        //Boton para volver
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal.Show();
        }


        private void Alta_Click(object sender, EventArgs e)
        {
            this.Close();
            var AltaEvento = new AltaEvento(tipoevento, FrmPrincipal, sistema);
            AltaEvento.Show();
        }

        //Cambio la variable que define(con un int de 1 a 3) el tipo de evento a dar de alta.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipoevento = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoevento = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipoevento = 3;
        }
    }
}
