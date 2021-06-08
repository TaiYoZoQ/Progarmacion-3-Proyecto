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
        private Sistema sistema;

        public FormularioPrincipal(Sistema sis)
        {
            sistema = sis;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form eventos = new Eventos(this, sistema);
            eventos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form alumnos = new Alumnos(this, sistema);
            alumnos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form tesoreria = new Tesoreria(this, sistema);
            tesoreria.Show();
            this.Hide();
        }
    }
}
