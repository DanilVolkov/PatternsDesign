using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizationMatrices
{
    class AddGraphicsBord : Border
    {
        Border border;
        public AddGraphicsBord(Border border)
        {
            this.border = border;
        }
        public override dynamic Bord(dynamic obj)
        {
            obj.BorderStyle = BorderStyle.FixedSingle;
            return obj;
        }
    }
}
