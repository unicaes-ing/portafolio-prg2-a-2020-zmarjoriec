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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string from, to;
            from = lstDe.SelectedItem.ToString();
            to = lstA.SelectedItem.ToString();
            if (from == "Pulgadas (in)" && to == "Pies (ft)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 0.083);

            }
            if (from == "Pulgadas (in)" && to == "Yardas (yd)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 0.027);

            }
            if (from == "Pies (ft)" && to == "Pulgadas (in)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 12);

            }
            if (from == "Pies (ft)" && to == "Yardas (yd)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 0.33);

            }
            if (from == "Yardas (yd)" && to == "Pulgadas (in)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 36);

            }
            if (from == "Yardas (yd)" && to == "Pies (ft)")
            {
                txtConversion.Text = Convert.ToString(Convert.ToInt32(txtLongitud.Text) * 36);


            }
            if (from == to)
            {
                MessageBox.Show("Has introducido las mismas unidades de conversión");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
