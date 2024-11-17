using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class VGroupMatrices : HGroupMatrices
    {
        private Dictionary<int, List<int[]>> transpose;
        public VGroupMatrices(params IMatrix[] matrices) : base(matrices)
        {
            CreateTranspose(base.matrices);

            //for (int i = 0; i < transpose.Count; i++)
            //{
            //    for (int j = 0; j < transpose[i].Count; j++)
            //    {
            //        if (base.GetItem(transpose[i][j][0], transpose[i][j][1]) == -1)
            //            Console.Write("  ");
            //        else
            //            Console.Write($"{base.GetItem(transpose[i][j][0], transpose[i][j][1])} ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
        }

        private void CreateTranspose(List<IMatrix> matrices)
        {
            transpose = new Dictionary<int, List<int[]>>();
            int rows = 0, columns = 0;

            foreach (IMatrix matrix in matrices)
            {
                if (matrix.IsComposite())
                {
                    for (int i = 0; i < matrix.CountRows; i++)
                    {
                        if (!transpose.ContainsKey(i + rows))
                            transpose.Add(i + rows, new List<int[]>());
                        for (int j = 0; j < matrix.CountColumns; j++)
                            transpose[i + rows].Add(new int[] { i, j + columns });
                    }
                }
                else
                {
                    for (int i = 0; i < matrix.CountColumns; i++)
                    {
                        if (!transpose.ContainsKey(i + rows))
                            transpose.Add(i + rows, new List<int[]>());
                        for (int j = 0; j < matrix.CountRows; j++)
                            transpose[i + rows].Add(new int[] { j, i + columns });
                    }
                }
                columns += matrix.CountColumns;
                rows += transpose.Count - rows;
            }
        }

        public override int CountRows => transpose.Count;

        public override int CountColumns
        {
            get
            {
                int result = 0;
                foreach (var elem in transpose)
                {
                    if (elem.Value.Count > result)
                        result = elem.Value.Count;
                }
                return result;
            }
        }

        public override void AddMatrix(IMatrix matrix)
        {
            base.AddMatrix(matrix);
            CreateTranspose(base.matrices);
        }

        public override int GetItem(int row, int column)
        {
            try
            {
                //Console.WriteLine(transpose[row][column][0]);
                //Console.WriteLine(transpose[row][column][1]);
                //Console.WriteLine(base.GetItem(transpose[row][column][0], transpose[row][column][1]));
                return base.GetItem(transpose[row][column][0], transpose[row][column][1]);
            }
            catch
            {
                return 0;
            }

        }

        public override void SetItem(int row, int column, int value)
        {
            base.SetItem(transpose[row][column][0], transpose[row][column][1], value);
        }

        private (int, int) GetMatrix(int row)
        {
            int currentRow = 0;
            int previousRow = 0;
            int index = 0;

            if (row < 0)
                throw new IndexOutOfRangeException("Index out of range");

            for (int i = 0; i < matrices.Count; i++)
            {
                previousRow = currentRow;
                currentRow += matrices[i].CountRows;
                if (row < currentRow)
                {
                    index = i;
                    break;
                }
            }
            currentRow = row - previousRow;
            return (currentRow, index);
        }


        public override void Draw(int value, int row, int col, IDrawer drawer)
        {
            // нужно получить текущую матрицу уже по row, а не column
            // так как в ADrawMatrix уже матрица выводиться как транспонированная, row и col уже транспонированы
            var currentObjects = GetMatrix(row);
            int currentRow = currentObjects.Item1;
            IMatrix currentMatrix = matrices[currentObjects.Item2];


            if (col >= currentMatrix.CountColumns)
                drawer.DrawItem(0, row, col);
            else
            {
                currentMatrix.Draw(value, currentRow, col, drawer);
            }

            



        }
    }
}
