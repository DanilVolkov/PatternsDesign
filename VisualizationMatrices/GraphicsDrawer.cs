using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VisualizationMatrices
{
    class GraphicsDrawer : IDrawer
    {
        DataGridView dataGridView;
        protected int lineCount;
        List<string> borders;

        public GraphicsDrawer(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            dataGridView.CellPainting += dataGridView_CellPainting;
            lineCount = 0;
            borders = new List<string>();
        }
        public void BeginDraw(IMatrix matrix)
        {
            dataGridView.Rows.Clear();
            dataGridView.RowCount = matrix.CountRows;
            dataGridView.ColumnCount = matrix.CountColumns;
        }

        public void BeginDrawItem(IMatrix matrix, int row, int col) { }

        public void BeginDrawRow(IMatrix matrix, int row) { }

        public virtual IDrawer Dispose() => this;

        public virtual void DrawBorder(IMatrix matrix) { }

        public void DrawItem(IMatrix matrix, int row, int col)
        {
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                if (dataGridView[i, row].Value is null)
                {
                    dataGridView[i, row].Value = matrix.GetItem(row, col);
                    break;
                }
            }
        }

        public void DrawItemBorder(IMatrix matrix, int row, int col) { }

        public void EndDraw(IMatrix matrix)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            borders.Clear();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (!(dataGridView[0, i].Value is null))
                {
                    borders.Add($"0 {i} begin");
                }
            }

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if ((j < dataGridView.ColumnCount - 1 && !(dataGridView[j, i].Value is null) && dataGridView[j + 1, i].Value is null) ||
                        (j == dataGridView.ColumnCount - 1 && !(dataGridView[j, i].Value is null)))
                    {
                        borders.Add($"{j} {i}");
                    }
                }
            }
        }

        public void EndDrawItem(IMatrix matrix, int row, int col) { }

        public void EndDrawRow(IMatrix matrix, int row) { }

        private void DrawBord(DataGridViewCellPaintingEventArgs e, Pen p, int x)
        {
            for (int i = 0; i < lineCount; i++)
            {
                e.Graphics.DrawLine(p, new Point(x + i * 3, e.CellBounds.Top), new Point(x + i * 3, e.CellBounds.Bottom));
                e.Graphics.DrawLine(p, new Point(x - i * 3, e.CellBounds.Top), new Point(x - i * 3, e.CellBounds.Bottom));
            }
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int count = 0;
            foreach (var border in borders)
            {
                if (border.Contains($"{e.ColumnIndex} {e.RowIndex}"))
                {
                    count++;
                }
            }
            if (count > 0)    
            {   
                e.Handled = true;
                using (Brush b = new SolidBrush(dataGridView.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }
                using (Pen p = new Pen(Brushes.Black))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    int x = e.ColumnIndex == 0 ? e.CellBounds.Left : e.CellBounds.Right - 1;
                    DrawBord(e, p, x);

                    if (count > 1)
                    {
                        x = e.CellBounds.Right - 1;
                        DrawBord(e, p, x);
                    }
                }
                e.PaintContent(e.ClipBounds);
            }
        }

        public void AddBorder()
        {
            lineCount++;
        }

        internal void DelBorder()
        {
            lineCount--;
        }
    }
}
