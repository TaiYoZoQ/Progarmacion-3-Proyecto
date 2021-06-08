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
        private Sistema sistema;

        public AltaEvento(int tipoDeEvento, Form fmrPrincipal, Sistema sis)
        {
            sistema = sis;
            Principal = fmrPrincipal;
            tipoevento = tipoDeEvento;
            InitializeComponent();

            //Esta función prepara gráficamente el formulario dependiendo del "tipo de evento" enviado desde el formulario anterior
            Iniciar();
        }
       

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            //Paso el texto del TextBox correspondiente al costo a double.
            double costo;
            bool parseExitoso = double.TryParse(TbCosto.Text, out costo);

            if (parseExitoso && TbNombre.Text != "")
            {

                //Como cada evento se crea con distintos constructores, recurrí a un switch.
                switch (tipoevento)
                {
                    case 1:
                        //Creo Curso presencial                        
                        var CursoP = new CursoPresencial(TbNombre.Text, costo, Convert.ToInt32(CBAulas.SelectedItem));
                        sistema.AgregarEvento(CursoP);
                        break;

                    case 2:
                        //Parseo el texto del TextBox de comisión y lo divido por 100 para convertir al formato que uso en el programa.
                        double comision;
                        parseExitoso = double.TryParse(TBComision.Text, out comision);
                        comision /= 100;

                        if (TBComision.Text != "" && parseExitoso)
                        {
                            //Creo Curso online
                            var CursoOn = new CursoOnline(TbNombre.Text, costo, comision);
                            sistema.AgregarEvento(CursoOn);
                            break;
                        }
                        else
                            MessageBox.Show("Ingrese Valor de commisión válido (Número entero entre 0 y 100)");
                        return;

                    case 3:
                        //Creo Charla
                        if (TBOrador.Text != "")
                        {
                            var Charla = new Charla(TbNombre.Text, costo, TBOrador.Text);
                            sistema.AgregarEvento(Charla);
                            break;
                        }
                        else
                            MessageBox.Show("Ingrese Nombre de Orador");
                        return;

                }
            }
            else
            {
                MessageBox.Show("Complete los campos vacíos");
                return;
            }
            MessageBox.Show("Alta Exitosa");
            Volver();
        }


        private void Iniciar()
        {
            switch (tipoevento)
            {
                case 1:
                    CBAulas.SelectedIndex = 1;
                    CBAulas.Show();
                    TextoTipo.Text="Aula: ";
                    break;
                case 2:
                    TBComision.Show();
                    TextoTipo.Text = "Comisión: %";
                    break;
                case 3:
                    TBOrador.Show();
                    TextoTipo.Text = "Orador: ";
                    break;
            }
        } 
        
        private void Volver()
        {
            this.Close();
            Principal.Show();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
