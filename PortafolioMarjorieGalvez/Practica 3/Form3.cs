using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random d = new Random();
            int n = 0;
            lstDado.Items.Clear();
            for (int i = 1; i <= 5000; i++)
            {
                int num = d.Next(1, 7);
                lstDado.Items.Add(num);
                if (num == 6) n++;


            }
            MessageBox.Show(" Se obtuvo " + n + " veces el 6 ");
        }
    }
}
