
namespace VisualizationMatrices
{
    class Matrix : SomeMatrix
    {
        public Matrix(List<Vector> vectors) : base(vectors) { }

        public Matrix(int rows, int columns) : base(rows, columns) { }

        public override void Draw(int value, int row, int col, IDrawer drawer, int countColumns)
        {
            drawer.DrawItem(value, row, col, countColumns);
        }        

        protected override IVector Create(int size) => new Vector(size);
    }
}
