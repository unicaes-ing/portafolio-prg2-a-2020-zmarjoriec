using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
			try
			{
				int numero = Convert.ToInt32(txtNum.Text);
				lstNumeros.Items.Add(numero);
				txtNum.Clear();
				txtNumBus.Clear();

			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese un numero");
				txtNum.SelectAll();
				txtNum.Focus();
			}
		}
		public static int buscar(int numBuscar, ListBox lista)
		{
			int cont = 0;

			foreach (int n in lista.Items)
			{
				if (n == numBuscar) cont++;

			}
			return cont;

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(txtNumBus.Text);
				int cant = buscar(num, lstNumeros);
				MessageBox.Show(" Se encuentra " + cant + " veces ");
			}
			catch (Exception)
			{
				MessageBox.Show("Ingrese un numero");
				txtNumBus.SelectAll();
				txtNumBus.Focus();
			}
		}
	}
}
