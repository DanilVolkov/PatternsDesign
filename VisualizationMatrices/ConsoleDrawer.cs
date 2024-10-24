using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class ConsoleDrawer : IDrawer
    {
        Border border;

        public ConsoleDrawer(Border border = null)
        {
            this.border = border;
            if (border is null)
            {
                this.border = new NoBord();
            }
        }
        
        public virtual void DMatrix(int[,] matrix)
        {
            string text = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    text += matrix[i, j] + " ";
                }
                text = text.Substring(0, text.Length - 1) + Environment.NewLine;
            }

            text = border.Bord(text);

            Program.form.textBox.Text = text;

        }
    }
}
