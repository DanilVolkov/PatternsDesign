namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix : IMatrix
    {

        private List<int> matrix;

        public int CountRows
        {
            get
            {
                return matrix.Count;
            }
        }

        public int CountColumns
        {
            get
            {
                return matrix[0]; 
            }
        }

        public void AddItem(int row, int column, int value)
        {
            throw new NotImplementedException();
        }

        public void AddRow(IVector vector)
        {
            throw new NotImplementedException();
        }

        public void AddRows(List<IVector> vectors)
        {
            throw new NotImplementedException();
        }

        public object GetItem(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
