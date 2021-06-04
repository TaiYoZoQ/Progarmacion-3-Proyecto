using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Prog_3
{
    public partial class AltaEvento : Form
    {
        private int tipoevento;
        private Form Principal;

        public AltaEvento(int tipoDeEvento, Form fmrPrincipal)
        {
            Principal = fmrPrincipal;
            tipoevento = tipoDeEvento;
            InitializeComponent();
            Iniciar();
        }
       

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            double costo;
            double.TryParse(TbCosto.Text, out costo);
            
            switch (tipoevento)
            {
                case 1:
                    var CursoP = new CursoPresencial(TbNombre.Text, costo, Convert.ToInt32(CBAulas.SelectedItem));
                    Sistema.AgregarEvento(CursoP);
                    break;

                case 2:
                    double comision;
                    double.TryParse(TBComision.Text, out comision);

                    var CursoOn = new CursoOnline(TbNombre.Text, costo, comision);
                    Sistema.AgregarEvento(CursoOn);
                    break;

                case 3:
                    var Charla = new Charla(TbNombre.Text, costo, TBOrador.Text);
                    Sistema.AgregarEvento(Charla);
                    break;

            }

            MessageBox.Show("Alta Exitosa");
            Volver();

        }


        private void Iniciar()
        {
            switch (tipoevento)
            {
                case 1:
                    CBAulas.Show();
                    TextoTipo.Text="Aula: ";
                    break;
                case 2:
                    TBComision.Show();
                    TextoTipo.Text = "Comisión: ";
                    break;
                case 3:
                    TBOrador.Show();
                    TextoTipo.Text = "Orador: ";
                    break;
            }
        } 
        
        private void Volver()
        {
            this.Hide();
            Principal.Show();
        }
    }
}
