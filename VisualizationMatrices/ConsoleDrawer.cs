using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class ConsoleDrawer : IDrawer
    {
        public virtual dynamic DBordMatrix(dynamic text)
        {
            return text;
        }

        public void DMatrix(int[,] matrix)
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

            text = DBordMatrix(text);

            Program.form.textBox.Text = text;

        }
    }

    class ConsoleBorder : ConsoleDrawer
    {
        IDrawer drawer;

        public ConsoleBorder(IDrawer drawer)
        {
            this.drawer = drawer;
        }

        public override dynamic DBordMatrix(dynamic text)
        {
            text = "|" + drawer.DBordMatrix(text).Replace(Environment.NewLine, $"|{Environment.NewLine}|");
            return text.Substring(0, text.Length - 1);
        }

        public IDrawer Dispose()
        {
            return drawer;
        }
    }
}
