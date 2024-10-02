namespace Lesson2VectorAndMatrix
{
    interface IMatrix
    {
        void AddItem(object value);

        void AddColumn();

        void AddColumns(int count);

        void AddRow();

        void AddRows(int count);

        object GetItem(int row, int column);

        int CountRows();

        int CountColumns();
    }
}
