using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double e1, e2, e3;
            e1 = Convert.ToDouble(txtExam1.Text);
            e2 = Convert.ToDouble(txtExam2.Text);
            e3 = Convert.ToDouble(txtExam3.Text);
            txtProm.Text = (e1 + e2 + e3 / 3.0).ToString("N2");
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtExam1.Text = "";
            txtExam2.Text = "";
            txtExam3.Text = "";
            txtProm.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
