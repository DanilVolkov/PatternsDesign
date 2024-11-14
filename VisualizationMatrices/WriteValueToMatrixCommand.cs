using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatrices
{
    class WriteValueToMatrixCommand : ACommand
    {
        private IMatrix matrix;
        private int row, column, newValue, prevValue;
        public WriteValueToMatrixCommand(IMatrix matrix, int row, int column, int newValue)
        {
            this.matrix = matrix;
            this.row = row;
            this.column = column;
            this.newValue = newValue;
        }

        public override void Undo()
        {
            matrix.SetItem(row, column, prevValue);
        }

        protected override void DoExecute()
        {
            prevValue = matrix.GetItem(row, column);
            matrix.SetItem(row, column, newValue);
            
        }
    }
}
