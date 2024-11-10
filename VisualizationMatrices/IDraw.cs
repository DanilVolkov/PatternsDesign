using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    interface IDraw
    {
        void Draw(IMatrix matrix, IDrawer drawer);
    }
}
