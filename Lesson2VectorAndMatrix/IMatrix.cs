namespace Lesson2VectorAndMatrix
{
    interface IMatrix
    {

        public int CountRows { get; }

        public int CountColumns { get; }

        void AddItem(int row, int column, int value);

        void AddRow(IVector vector);

        void AddRows(List<IVector> vectors);

        object GetItem(int row, int column);
    }
}
