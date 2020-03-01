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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
			dgvTabla.Size = new Size(210, 220);
			dgvTabla.AllowUserToAddRows = false;
			dgvTabla.ScrollBars = ScrollBars.None;
			dgvTabla.ColumnCount = 10;
			dgvTabla.ColumnHeadersVisible = false;
			dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			Random r = new Random();
			for (int i = 0; i < 10; i++)
			{
				dgvTabla.Rows.Add();
				for (int C = 0; C < 10; C++)
				{
					dgvTabla.Rows[i].Cells[C].Value = r.Next(10, 100);
				}

			}
			dgvTabla.ClearSelection();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            int num = Convert.ToInt32(txtNumeroBu.Text);

            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    string valor;
                    valor = dgvTabla.Rows[f].Cells[c].Value.ToString();
                    if (num == Convert.ToInt32(valor))
                    {
                        dgvTabla.Rows[f].Cells[c].Style.BackColor = Color.Yellow;
                    }
                }
            }
        }
	}
}
