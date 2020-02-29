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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
			int num;
			if (int.TryParse(txtNum.Text, out num))
			{
				lstTablas.Items.Clear();
				for (int i = 1; i <= 10; i++)
				{
					lstTablas.Items.Add(num + "*" + i + "=" + num * i);

				}

			}
			else
			{
				MessageBox.Show("Ingrese un numero a la tabla");
			}
		}
    }
}
