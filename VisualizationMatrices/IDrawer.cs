using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    interface IDrawer
    {
        void DRow(int[] values, int row, int column);
        void DCell(int value, int row, int column);
        void DBordMatrix(int row, int col);
        void DMatrix(int[,] matrix);
        
    }
}
