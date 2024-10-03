namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix<T> : IMatrix
    {

        private Dictionary<Tuple<int, int>, T> matrix;

        public int CountRows
        {
            get
            {
                return matrix.Count;
            }
        }

        public abstract int? CountColumns{ get; }

        public abstract void AddItem(int row, int column, int value);

        public abstract object GetItem(int row, int column);
    }
}
