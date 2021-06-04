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

        public Eventos(Form Principal)
        {
            FrmPrincipal = Principal;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal.Show();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AltaEvento = new AltaEvento(tipoevento, FrmPrincipal);
            AltaEvento.Show();
        }

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
