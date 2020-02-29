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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstLetras.ForeColor = Color.Pink;
            lstLetras.Font = new Font("Calibri", 20, FontStyle.Italic | FontStyle.Underline);
            lstLetras.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstLetras.Items.Add(letra);
            }
            lstLetras.Items.Insert(14, "Ñ");
        }
    }
}
