namespace Lesson2VectorAndMatrix
{
    interface IMatrix
    {

        public int CountRows { get; }

        public int? CountColumns { get; }

        void SetItem(int row, int column, int value);

        object GetItem(int row, int column);
    }
}
