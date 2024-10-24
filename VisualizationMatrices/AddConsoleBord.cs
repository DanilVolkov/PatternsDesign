using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    //class AddConsoleBord : Border
    //{
    //    Border border;
    //    public AddConsoleBord(Border border)
    //    {
    //        this.border = border;
    //    }
    //    public override string Bord(dynamic obj)
    //    {
    //        obj = "|" + border.Bord(obj).Replace(Environment.NewLine, $"|{Environment.NewLine}|");
    //        obj = obj.Substring(0, obj.Length - 1); // удаляем лишнюю границу
    //        return obj;
    //    }
    //}

    class AddConsoleBord : ConsoleDrawer
    {
        ConsoleDrawer drawer;
        public AddConsoleBord(ConsoleDrawer drawer)
        {
            this.drawer = drawer;
        }
        public string Bord(int[,] matrix)
        {
            //text = "|" + drawer.DMatrix(matrix).Replace(Environment.NewLine, $"|{Environment.NewLine}|");
            //text = text.Substring(0, text.Length - 1); // удаляем лишнюю границу
            //return text;
        }
    }


}
