using System;

namespace VisualizationMatrices
{
    class RenumberingDecorator : IMatrix
    {
        IMatrix matrix;
        Dictionary<int, int> redefinition_columns;
        Dictionary<int, int> redefinition_rows;
        Random random = new Random();
        public RenumberingDecorator(IMatrix matrix)
        {
            this.matrix = matrix;

            redefinition_columns = new Dictionary<int, int>();
            redefinition_rows = new Dictionary<int, int>();

        }
        public void RenumerateColumns()
        {
            Renumerate(matrix.CountColumns, redefinition_columns);
        }

        public void RenumerateRows()
        {
            Renumerate(matrix.CountRows, redefinition_rows);
        }

        private void Renumerate(int max_size, Dictionary<int, int> redefinition)
        {
            List<int> columns = new List<int>(Enumerable.Range(0, max_size));

            KeyValuePair<int, int> choice_col = GenerateRandomPair(max_size);

            Swap(columns, choice_col.Key, choice_col.Value);

            for (int i = 0; i < max_size; i++)
            {
                redefinition.Add(i, columns[i]);
            }
        }

        private KeyValuePair<int, int> GenerateRandomPair(int max_size)
        {
            
            int result_1 = random.Next(max_size);
            int result_2 = random.Next(max_size);
            while (result_2 == result_1)
            {
                result_2 = random.Next(max_size);
            }
            return new KeyValuePair<int, int>(result_1, result_2);
        }

        private void Swap(List<int> list, int index_1, int index_2)
        {
            int tmp = list[index_1];
            list[index_1] = list[index_2];
            list[index_2] = tmp;
        }
        public int CountRows => matrix.CountRows;

        public int CountColumns => matrix.CountColumns;

        public void Draw(IDrawer drawer, IMatrix obj = null)
        {
            matrix.Draw(drawer, this);
        }

        public int GetItem(int row, int column)
        {
            return matrix.GetItem(redefinition_rows[row], redefinition_columns[column]);
        }

        public void SetItem(int row, int column, int value)
        {
            matrix.SetItem(row, column, value);
        }

        public IMatrix Recover()
        {
            return matrix;
        }
    }
}
