using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson2VectorAndMatrix
{
    class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(List<Vector> vectors) : base(vectors) { }

        public SparseMatrix(int rows, int columns) : base(rows, columns) { }

        protected override IVector Create(int size) => new Vector(size);
    }
}
