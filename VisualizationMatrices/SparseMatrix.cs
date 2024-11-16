using System.ComponentModel.DataAnnotations.Schema;

namespace VisualizationMatrices
{
    class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(List<SparseVector> vectors) : base(vectors) { }

        public SparseMatrix(int rows, int columns) : base(rows, columns) { }

        public override void Draw(int value, int row, int col, IDrawer drawer, int countColumns)
        {
            if (value != 0)
            {
                drawer.DrawItem(value, row, col, countColumns);
            }
        }

        protected override IVector Create(int size) => new SparseVector(size);
    }
}
