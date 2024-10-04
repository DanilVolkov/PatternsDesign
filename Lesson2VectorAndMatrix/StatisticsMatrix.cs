namespace Lesson2VectorAndMatrix
{
    class StatisticsMatrix
    {
        private SomeMatrix matrix;

        public int Sum
        {
            get
            {
                int result = 0;
                for (int i = 0; i < matrix.CountRows;  i++)
                {
                    for (int j = 0; j < matrix.CountColumns; j++)
                    {
                        result += matrix.GetItem(i, j);
                    }
                }
                return result;
            }
        }

        public double Average
        {
            get
            {
                return Math.Round((double)this.Sum / (matrix.CountRows * matrix.CountColumns), 2);
            }
        }

        public double Max
        {
            get
            {
                double result = double.NegativeInfinity;
                for (int i = 0; i < matrix.CountRows; i++)
                {
                    for (int j = 0; j < matrix.CountColumns; j++)
                    {
                        if (matrix.GetItem(i, j) > result)
                            result = matrix.GetItem(i, j);
                    }
                }
                return (int)result;
            }
        }

        public int CountNoZero
        {
            get
            {
                int result = 0;
                for (int i = 0; i < matrix.CountRows; i++)
                {
                    for (int j = 0; j < matrix.CountColumns; j++)
                    {
                        if (matrix.GetItem(i, j) != 0)
                            result++;
                    }
                }
                return result;
            }
        }

        public StatisticsMatrix(SomeMatrix matrix)
        {
            this.matrix = matrix;
        }
        
    }
}
