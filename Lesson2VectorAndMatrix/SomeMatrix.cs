namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix : IMatrix
    {
        public abstract int CountRows { get; }

        public abstract int? CountColumns{ get; }

        public abstract void SetItem(int row, int column, int value);

        public abstract object GetItem(int row, int column);
    }
}
