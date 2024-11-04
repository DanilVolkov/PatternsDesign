using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeMatrix
{
    class HGroupMatrices : IMatrix
    {
        List<IMatrix> matrices;

        public HGroupMatrices(params IMatrix[] matrices)
        {
            this.matrices = new List<IMatrix>();

            for (int i = 0; i < matrices.Length; i++)
            {
                this.matrices.Add(matrices[i]);
            }
        }

        public void AddMatrix(IMatrix matrix)
        {
            matrices.Add(matrix);
        }


        public virtual int CountRows
        {
            get
            {
                int result = 0;

                foreach (IMatrix matrix in matrices)
                {
                    if (matrix.CountRows > result)
                    {
                        result = matrix.CountRows;
                    }
                }

                return result;
            }
        }

        public virtual int CountColumns
        {
            get
            {
                int result = 0;

                foreach (IMatrix matrix in matrices)
                {
                    result += matrix.CountColumns;
                }

                return result;
            }
        }

        public virtual int GetItem(int row, int column)
        {
            var currentObjects = GetMatrixColumn(row, column);
            int currentColumn = currentObjects.Item1;
            IMatrix currentMatrix = currentObjects.Item2;

            if (row >= currentMatrix.CountRows)
                return -1;

            return currentMatrix.GetItem(row, currentColumn);
        }


        public virtual void SetItem(int row, int column, int value)
        {
            var currentObjects = GetMatrixColumn(row, column);
            int currentColumn = currentObjects.Item1;
            IMatrix currentMatrix = currentObjects.Item2;

            if (row >= currentMatrix.CountRows)
                throw new IndexOutOfRangeException("Index out of range");

            currentMatrix.SetItem(row, currentColumn, value);
        }

        public bool IsComposite()
        {
            return true;
        }

        protected (int, IMatrix) GetMatrixColumn(int row, int column)
        {
            IMatrix currentMatrix = matrices[0];
            int currentColumn = 0;
            int previousColumn = 0;

            //как сделать чтобы CountColumns обращался не к переопределенному свойству
            //if (row < 0 || column < 0 || row >= CountRows || column >= CountColumns)
            //    throw new IndexOutOfRangeException("Index out of range");
            if (row < 0 || column < 0)
                throw new IndexOutOfRangeException("Index out of range");

            for (int i = 0; i < matrices.Count; i++)
            {
                previousColumn = currentColumn;
                currentColumn += matrices[i].CountColumns;
                if (column < currentColumn)
                {
                    currentMatrix = matrices[i];
                    break;
                }
            }
            currentColumn = column - previousColumn;
            return (currentColumn, currentMatrix);
        }
    }
}
