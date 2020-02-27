using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                string romano = "";
                if (numero >= 1 && numero <= 3)
                {
                    if (numero == 1)
                    {
                        romano = "I";
                    }
                    else if (numero == 2)
                    {
                        romano = "II";

                    }
                    else if (numero == 3)
                    {
                        romano = "III";

                    }
                    lblRom.Text = "Equivale a " + romano + "en numero romano";

                }
                else
                {
                    txtNumero.Focus();
                    txtNumero.SelectAll();
                    lblRom.Text = "Ingrese numeros del 1 al 3";

                }
            }
            catch (Exception)
            {
                txtNumero.Focus();
                txtNumero.SelectAll();
                lblRom.Text = "Error. Ingrese los numeros dentro del rango";


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
