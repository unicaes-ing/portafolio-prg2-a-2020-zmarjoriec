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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[,] A = new int[5, 5];
        int[,] B = new int[5, 5];

        private void Form2_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            dgvA.ColumnCount = 5;
            dgvA.ColumnHeadersVisible = false;
            dgvA.RowHeadersVisible = false;
            dgvA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvB.ColumnCount = 5;
            dgvB.ColumnHeadersVisible = false;
            dgvB.RowHeadersVisible = false;
            dgvB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int f = 0; f < A.GetLength(0); f++)
            {
                dgvA.Rows.Add();
                dgvB.Rows.Add();
                for (int c = 0; c < B.GetLength(0); c++)
                {
                    A[f, c] = r.Next(10, 91);
                    B[f, c] = r.Next(10, 91);
                    dgvA.Rows[f].Cells[c].Value = A[f, c];
                    dgvB.Rows[f].Cells[c].Value = B[f, c];

                }
            }

        }

        private void rdoSumar_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static int[,] sumar(int [, ]MatrizA, int[,] MatrizB, RadioButton ch)
        {
            int[,] Resultado = new int[5, 5];
            if (ch.Checked)
            {
                for (int f = 0; f < Resultado.GetLength(0); f++)
                {
                    for (int c = 0; c < Resultado.GetLength(1); c++)
                    {
                        Resultado[f, c] = MatrizA[f, c] + MatrizB[f, c];
                    }
                }
            }
            return Resultado;
        }
        public static int[,] multiplicar(int[,] MatrizA, int[,] MatrizB, RadioButton ch)
        {
            int[,] Resultado = new int[5, 5];
            if (ch.Checked)
            {
                for (int f = 0; f < Resultado.GetLength(0); f++)
                {
                    for (int c = 0; c < Resultado.GetLength(1); c++)
                    {
                        Resultado[f, c] = MatrizA[f, c] * MatrizB[f, c];
                    }
                }
            }
            return Resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[,] Resultado = new int[5, 5];
            dgvC.Rows.Clear();
            dgvC.Columns.Clear();
            dgvC.AllowUserToAddRows = false;
            dgvC.ScrollBars = ScrollBars.Both;
            dgvC.ColumnCount = 5;
            dgvC.ColumnHeadersVisible = false;
            dgvC.RowHeadersVisible = false;
            int[,] resp = new int[5, 5];
            if (rdoSumar.Checked)
            {
                resp = sumar(A, B, rdoSumar);
                for (int f = 0; f < A.GetLength(0); f++)
                {
                    dgvC.Rows.Add();
                    for (int c = 0; c < A.GetLength(1); c++)
                    {
                        dgvC.Rows[f].Cells[c].Value = resp[f, c];
                    }
                }

            }
            else
            {
                resp = multiplicar(A, B, rdoMultiplicar);
                for (int f = 0; f < A.GetLength(0); f++)
                {
                    dgvC.Rows.Add();
                    for (int c = 0; c < A.GetLength(1); c++)
                    {
                        dgvC.Rows[f].Cells[c].Value = resp[f, c];
                    }
                }
            }
        }
    }
}
