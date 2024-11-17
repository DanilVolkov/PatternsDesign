using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    interface IDrawer
    {
        void BeginDraw(IMatrix matrix);
        void BeginDrawRow(IMatrix matrix, int row);
        void BeginDrawItem(IMatrix matrix, int row, int col);
        void DrawItemBorder(IMatrix matrix, int row, int col);
        void DrawItem(int value, int row, int col);
        void EndDrawItem(IMatrix matrix, int row, int col);
        void EndDrawRow(IMatrix matrix, int row);
        void DrawBorder(IMatrix matrix);
        void EndDraw(IMatrix matrix);
        void SetColor(Color color);
        IDrawer Dispose();
    }
}
