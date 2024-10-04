namespace Lesson2VectorAndMatrix
{
    class Matrix : SomeMatrix
    {
        private Dictionary<int, Vector> matrix;
        public override int? CountColumns
        {
            get
            {
                return matrix.Count;
            }
        }

        public override int CountRows
        {
            get
            {
                return matrix[0].Length;
            }
        }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Matrix must have row or column sizes greater than 0");
            }
            matrix = new Dictionary<int, Vector>();
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(i, new Vector(columns));
            }
        }

        public Matrix(List<Vector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<int, Vector>();
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

        public override void SetItem(int row, int column, int value)
        {
            try
            {
                matrix[row].SetItem(column, value);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"{row} was out of range. Must be non-negative and less than {this.CountRows}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public override object GetItem(int row, int column)
        {
            try
            {
                return matrix[row].GetItem(column);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"{row} was out of range. Must be non-negative and less than {row}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return 0;
        }
    }
}
