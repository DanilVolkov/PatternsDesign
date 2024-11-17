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

            //Console.WriteLine();
            //for (int i = 0; i < matrix.CountRows; i++)
            //{
            //    for (int j = 0; j < matrix.CountColumns; j++)
            //        Console.Write(matrix.GetItem(i, j) + " ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            drawer.BeginDraw(matrix);
            if (IsSparseMatrix())
            {
                drawer.SetColor(Color.LightGreen);
            }
            else
            {
                drawer.SetColor(Color.White);
            }
            drawer.DrawBorder(matrix);
            for (int row = 0; row < matrix.CountRows; row++)
            {
                drawer.BeginDrawRow(matrix, row);
                for (int col = 0; col < matrix.CountColumns; col++)
                {
                    if (!Condition(matrix, row, col)) continue;
                    drawer.BeginDrawItem(matrix, row, col);
                    drawer.DrawItemBorder(matrix, row, col);
                    matrix.Draw(matrix.GetItem(row, col), row, col, drawer);
                    //drawer.DrawItem(matrix, row, col);
                    drawer.EndDrawItem(matrix, row, col);

                }
                drawer.EndDrawRow(matrix, row);
            }
            drawer.EndDraw(matrix);
        }

        protected abstract bool IsSparseMatrix();

        protected abstract bool Condition(IMatrix matrix, int row, int col);
    }

    class DrawMatrix : ADrawMatrix
    {
        protected override bool Condition(IMatrix matrix, int row, int col)
        {
            return true;
        }

        protected override bool IsSparseMatrix()
        {
            return false;
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

        protected override bool IsSparseMatrix()
        {
            return true;
        }
    }
}
