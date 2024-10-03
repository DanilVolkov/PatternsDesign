using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2VectorAndMatrix
{
    class Matrix : SomeMatrix<Vector>
    {
        public override int? CountColumns => throw new NotImplementedException();

        public override void AddItem(int row, int column, int value)
        {
            throw new NotImplementedException();
        }

        public override object GetItem(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
