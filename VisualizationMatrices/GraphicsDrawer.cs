using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationMatrices
{
    class GraphicsDrawer : IDrawer
    {
        Border border;

        public GraphicsDrawer(Border border = null)
        {
            this.border = border;
            if (border is null)
            {
                this.border = new NoBord();
            }
        }

        public void DMatrix(int[,] matrix)
        {
            DataGridView dataGridView = Program.form.dataGridView;
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                    dataGridView[j, i].Value = matrix[i, j];
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView = border.Bord(dataGridView);


        }
    }
}
