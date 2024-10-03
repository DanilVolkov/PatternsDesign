namespace Lesson2VectorAndMatrix
{
    interface IMatrix
    {

        public int CountRows { get; }

        public int CountColumns { get; }

        void AddItem(int value);

        void AddColumn();

        void AddColumns(int count);

        void AddRow();

        void AddRows(int count);

        object GetItem(int row, int column);
    }
}
