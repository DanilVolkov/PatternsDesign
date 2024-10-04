namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix : IMatrix
    {
        protected Dictionary<int, dynamic> matrix;
        public int CountColumns
        {
            get
            {
                return matrix.Count;
            }
        }

        public int CountRows
        {
            get
            {
                return matrix[0].Length;
            }
        }

        public void SetItem(int row, int column, int value)
        {
            try
            {
                matrix[row].SetItem(column, value);
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"{row} was out of range. Must be non-negative and less than {this.CountRows}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public object GetItem(int row, int column)
        {
            try
            {
                return matrix[row].GetItem(column);
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"{row} was out of range. Must be non-negative and less than {row}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}

