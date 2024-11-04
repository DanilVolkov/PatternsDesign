
namespace CompositeMatrix
{
    class Matrix : SomeMatrix
    {
        public Matrix(List<Vector> vectors) : base(vectors) { }

        public Matrix(int rows, int columns) : base(rows, columns) { }

        protected override IVector Create(int size) => new Vector(size);
    }
}
