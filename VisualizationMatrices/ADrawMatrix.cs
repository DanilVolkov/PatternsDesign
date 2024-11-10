using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    abstract class ADrawMatrix : IDraw
    {
        public void Draw(IMatrix matrix, IDrawer drawer)
        {
            drawer.BeginDraw(matrix);
            drawer.DrawBorder(matrix);
            for (int row = 0; row < matrix.CountRows; row++)
            {
                drawer.BeginDrawRow(matrix, row);
                for (int col = 0; col < matrix.CountColumns; col++)
                {
                    if (!Condition(matrix, row, col)) continue;
                    drawer.BeginDrawItem(matrix, row, col);
                    drawer.DrawItemBorder(matrix, row, col);
                    drawer.DrawItem(matrix, row, col);
                    drawer.EndDrawItem(matrix, row, col);

                }
                drawer.EndDrawRow(matrix, row);
            }
            drawer.EndDraw(matrix);
        }

        protected abstract bool Condition(IMatrix matrix, int row, int col);
    }

    class DrawMatrix : ADrawMatrix
    {
        protected override bool Condition(IMatrix matrix, int row, int col)
        {
            return true;
        }
    }

    class DrawSparseMatix : ADrawMatrix
    {
        protected override bool Condition(IMatrix matrix, int row, int col)
        {
            if (matrix.GetItem(row, col) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
