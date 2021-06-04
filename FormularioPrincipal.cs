using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Prog_3
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var eventos = new Eventos(this);
            eventos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var alumnos = new Alumnos(this);
            alumnos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tesoreria = new Tesoreria(this);
            tesoreria.Show();
            this.Hide();
        }
    }
}
