using System.Diagnostics;

namespace VisualizationMatrices
{
    abstract class SomeMatrix : IMatrix
    {
        protected Dictionary<int, IVector> matrix;
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
                return matrix[0].Length;
            }
        }

        public SomeMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new Exception("Matrix must have row or column sizes greater than 0");
            }
            matrix = new Dictionary<int, IVector>();
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(i, Create(columns));
            }
        }

        protected abstract IVector Create(int size);

        public SomeMatrix(List<Vector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<int, IVector>();
            int countColumns = vectors[0].Length;
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i].Length != countColumns)
                {
                    throw new Exception("Dimensions of the vectors must be the same");
                }
                matrix.Add(i, vectors[i].Copy(vectors[i]));
            }
        }

        public SomeMatrix(List<SparseVector> vectors)
        {

            if (vectors.Count <= 0)
            {
                throw new Exception("Matrix must have row size greater than 0");
            }

            matrix = new Dictionary<int, IVector>();
            int countColumns = vectors[0].Length;
            for (int i = 0; i < vectors.Count; i++)
            {
                if (vectors[i].Length != countColumns)
                {
                    throw new Exception("Dimensions of the vectors must be the same");
                }
                matrix.Add(i, vectors[i].Copy(vectors[i]));
            }
        }

        public void SetItem(int row, int column, int value)
        {
            try
            {
                matrix[row].SetItem(column, value);
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"{row} was out of range. Must be non-negative and less than {this.CountRows}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public int GetItem(int row, int column)
        {
            try
            {
                return matrix[row].GetItem(column);
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"{row} was out of range. Must be non-negative and less than {row}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public void Draw(IDrawer drawer, IMatrix obj = null)
        {
            if (obj is null)
            {
                obj = this;
            }

            drawer.BeginDraw(obj);
            drawer.DrawBorder(obj);
            for (int row = 0; row < obj.CountRows; row++)
            {
                drawer.BeginDrawRow(obj, row);
                for (int col = 0; col < obj.CountColumns; col++)
                {
                    if (!Condition(obj, row, col)) continue;
                    drawer.BeginDrawItem(obj, row, col);
                    drawer.DrawItemBorder(obj, row, col);
                    drawer.DrawItem(obj, row, col);
                    drawer.EndDrawItem(obj, row, col);

                }
                drawer.EndDrawRow(obj, row);
            }
            drawer.EndDraw(obj);
        }

        protected abstract bool Condition(IMatrix someMatrix, int row, int col);
    }
}

