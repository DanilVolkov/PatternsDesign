using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace VisualizationMatrices
{
    class GraphicsDrawer : IDrawer
    {
        public virtual dynamic DBordMatrix(dynamic obj)
        {
            obj.BorderStyle = BorderStyle.None;
            return obj;
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

            dataGridView = DBordMatrix(dataGridView);
        }
    }
    class GraphicsBorder : GraphicsDrawer
    {
        IDrawer drawer;

        public GraphicsBorder(IDrawer drawer)
        {
            this.drawer = drawer;
        }

        public override dynamic DBordMatrix(dynamic obj)
        {
            obj.BorderStyle = BorderStyle.FixedSingle;
            return obj;
        }

        public IDrawer Dispose()
        {
            return drawer;
        }
    }
}
