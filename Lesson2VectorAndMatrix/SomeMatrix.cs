namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix : IMatrix
    {

        private List<IVector>? matrix;

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
                return matrix[0].Count; // TODO: добавить получение размерностей всех векторов и отдельный метод для получения размерности отдельной строки
            }
        }

        public void AddColumn()
        {
            throw new NotImplementedException();
        }

        public void AddColumns(int count)
        {
            throw new NotImplementedException();
        }

        public void AddItem(int value)
        {
            throw new NotImplementedException();
        }

        public void AddRow()
        {
            throw new NotImplementedException();
        }

        public void AddRows(int count)
        {
            throw new NotImplementedException();
        }

        public object GetItem(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
