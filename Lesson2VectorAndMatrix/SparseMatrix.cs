using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson2VectorAndMatrix
{
    class SparseMatrix: SomeMatrix
    {

        private Dictionary<Tuple<int, int>, SparseVector> matrix;

        private int countColumns;

        private int countRows;

        public override int? CountColumns
        {
            get
            {
                return countColumns;
            }
        }

        public override int CountRows
        {
            get
            {
                return countRows;
            }
        }

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Matrix must have row or column sizes greater than 0");
            }
            matrix = new Dictionary<Tuple<int, int>, SparseVector>();

            countColumns = columns;
            countRows = rows;
        }

        public SparseMatrix(List<SparseVector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<Tuple<int, int>, SparseVector>();
            int countColumns = vectors[0].Length;
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i].Length != countColumns)
                {
                    throw new Exception("Dimensions of the vectors must be the same");
                }
                matrix.Add((i, j), vectors[i].Copy(vectors[i]));
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
