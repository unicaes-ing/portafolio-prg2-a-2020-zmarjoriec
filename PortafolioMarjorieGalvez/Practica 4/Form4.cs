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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private static int NumM(int num1, int num2, int num3)
        {
            int n1, n2, n3;
            n1 = num1;
            n2 = num2;
            n3 = num3;
            if (n1>n2 && n1>n3)
            {
                return n1;
            }
            else if (n2>n1 && n2>n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
        private void btnMayor_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3, nMayor;
            numero1 = Convert.ToInt32(txt1.Text);
            numero2 = Convert.ToInt32(txt2.Text);
            numero3 = Convert.ToInt32(txt3.Text);
            nMayor = NumM(numero1, numero2, numero3);
            lblMayor.Text = string.Format("{0}",  nMayor);


        }
    }
}
