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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Vendedores = { "Jose", "Daniel", "Ashley", "Carolina", "Ximena" };

        private void Form1_Load(object sender, EventArgs e)
        {
            lstVendedores.DataSource = Vendedores;

        }

        private void btnAZ_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(Vendedores);
            lstVendedores.DataSource=Vendedores;
        }

        private void btnZA_Click(object sender, EventArgs e)
        {
            lstVendedores.DataSource = null;
            Array.Sort(Vendedores);
            Array.Reverse(Vendedores);
            lstVendedores.DataSource = Vendedores;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lstVendedores.SelectedIndex>=0)
            {
                List<string> lista = new List<string>(Vendedores);
                lista.RemoveAt(lstVendedores.SelectedIndex);
                Vendedores = lista.ToArray();
                lstVendedores.DataSource = Vendedores;
                lstVendedores.SelectedIndex = -1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength>0)
            {
                int i = Array.IndexOf(Vendedores, txtNombre.Text);
                if (i>=0)
                {
                    lstVendedores.SelectedIndex=i;
                }
                else
                {
                    MessageBox.Show("El nombre pedido no está en la lista");
                }
            }
        }
    }
}
