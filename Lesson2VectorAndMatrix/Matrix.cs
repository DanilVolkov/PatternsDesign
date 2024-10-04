namespace Lesson2VectorAndMatrix
{
    class Matrix : SomeMatrix
    {
        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Matrix must have row or column sizes greater than 0");
            }
            base.matrix = new Dictionary<int, dynamic>();
            for (int i = 0; i < rows; i++)
            {
                base.matrix.Add(i, new Vector(columns));
            }
        }

        public Matrix(List<Vector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<int, dynamic>();
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
