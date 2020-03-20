using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[][] datos = new string[5][];


        private void Form3_Load(object sender, EventArgs e)
        {
            datos[0]= new string[3] { "30", "45", "52" };
            datos[1] = new string[4] { "40", "60", "20", "15" };
            datos[2] = new string[5] { "35", "75", "10", "25", "60" };
            datos[3] = new string[7] { "3", "10", "12", "50", "30", "10", "65" };
            datos[4] = new string[2] { "100", "40" };
            lstSucursales.Items.Clear();
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                lstSucursales.Items.Add("Sucursal " + (i + 1));

            }

        }

        private void lstSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (lstSucursales.SelectedIndex>=0)
            {
                lstVentas.Items.Clear();
                foreach (string  ventas in datos[lstSucursales.SelectedIndex])
                {
                    lstVentas.Items.Add(ventas);
                    total += Convert.ToInt32(ventas);

                }
            }
            lblMTotal.Text = string.Format(" {0}{1} ", " $ ", total );
        }
    }
}
