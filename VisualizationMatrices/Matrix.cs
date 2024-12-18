﻿
namespace VisualizationMatrices
{
    class Matrix : SomeMatrix
    {
        public Matrix(List<Vector> vectors) : base(vectors) { }

        public Matrix(int rows, int columns) : base(rows, columns) { }

        public override void Draw(int value, int row, int col, IDrawer drawer)
        {
            drawer.DrawItem(value, row, col);
        }

        //protected override bool Condition(IMatrix someMatrix, int row, int col) => true;

        protected override IVector Create(int size) => new Vector(size);
    }
}
