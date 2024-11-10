using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class AProperties : IProperties
    {
        private Color color = Color.White;
        private int border = 0;

        public AProperties(Color color, int border = 0)
        {
            this.color = color;
            this.border = border;
        }
        public Color Colors { get => color; set => color = value; }
        public int Border { get => border; set => border = value; }
    }
}
