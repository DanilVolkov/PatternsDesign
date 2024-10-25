using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    interface IDrawer
    {
        dynamic DBordMatrix(dynamic matrix);
        void DMatrix(int[,] matrix);
        
    }
}
