using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class ConsoleDrawer : IDrawer
    {
        public void DBordMatrix(int row, int col)
        {

        }

        public void DCell(int value, int row, int column)
        {
            
        }

        public void DMatrix(int[,] matrix)
        {
            string text = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    text += matrix[i, j] + "";
                }
                text += Environment.NewLine;
            }

            Program.form.textBox.Text = text;

        }

        public void DRow(int[] values, int row, int column)
        {

        }
    }
}
