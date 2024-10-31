using System.Data.Common;

namespace VisualizationMatrices
{
    class InitMatrix
    {
        public static void FillMatrix(IMatrix matrix, int countNoZero, int maxValue)
        {
            int countRows = matrix.CountRows;
            int countColumns = matrix.CountColumns;
            if (countNoZero <= 0)
            {
                throw new ArgumentException("Argument 'countNoZero' must be greater than zero");
            }
            countNoZero = countNoZero >= countRows * countColumns ? countRows * countColumns : countNoZero;

            List<int> randomValues = new List<int>();

            Random rand = new Random();
            int index = 0;
            // формируем массив случайных значений
            while (index < countNoZero)
            {
                int randomNumber = rand.Next(1, maxValue);
                if (!randomValues.Contains(randomNumber))
                {
                    randomValues.Add(randomNumber);
                    index++;
                }
            }

            // формируем список пар строк и столбцов
            List<(int row, int column)>allCells = new List<(int row, int column)>();
            for (int i = 0; i < countRows; i++)
            {
                for (int j = 0; j < countColumns; j++)
                {
                    allCells.Add((i, j));
                }
            }

            // выбираем из списка пар рандомную ячейку, присваиваем ей значение в матрице и удаляем из списка
            for (int i = 0; i < countNoZero; i++)
            {
                int randomIndex = rand.Next(allCells.Count);
                (int row, int column) randomCell = allCells[randomIndex];
                matrix.SetItem(randomCell.row, randomCell.column, randomValues[0]);
                allCells.RemoveAt(randomIndex);
                randomValues.RemoveAt(0);
            }
        }
    }
}
