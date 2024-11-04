using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CompositeMatrix
{
    class VGroupMatrices : HGroupMatrices
    {
        public VGroupMatrices(params IMatrix[] matrices) : base(matrices) { }

        public override int CountRows
        {
            get
            {
                if (IsComposite())
                    return base.CountRows;
                return base.CountColumns;
            }
        }

        public override int CountColumns
        {
            get
            {
                if (IsComposite())
                    return base.CountColumns;
                return base.CountRows;
            }
        }

        public override int GetItem(int row, int column)
        {
            if (IsComposite())
            {
                return base.GetItem(row, column);
            }
            return base.GetItem(column, row);

        }

        public override void SetItem(int row, int column, int value)
        {
            //base.SetItem(column, row, value);
        }
    }
}
