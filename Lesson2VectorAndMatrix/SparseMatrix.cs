using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson2VectorAndMatrix
{
    class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Matrix must have row or column sizes greater than 0");
            }
            base.matrix = new Dictionary<int, IVector>();
            for (int i = 0; i < rows; i++)
            {
                base.matrix.Add(i, new SparseVector(columns));
            }
        }

        public SparseMatrix(List<SparseVector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<int, IVector>();
            int countColumns = vectors[0].Length;
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i].Length != countColumns)
                {
                    throw new Exception("Dimensions of the vectors must be the same");
                }
                matrix.Add(i, vectors[i].Copy(vectors[i]));
            }
        }
    }
}
