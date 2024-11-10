using System.ComponentModel.DataAnnotations.Schema;

namespace VisualizationMatrices
{
    class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(List<SparseVector> vectors) : base(vectors) { }

        public SparseMatrix(int rows, int columns) : base(rows, columns) { }

        //protected override bool Condition(IMatrix someMatrix, int row, int col)
        //{
        //    if (someMatrix.GetItem(row, col) == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        protected override IVector Create(int size) => new SparseVector(size);
    }
}
