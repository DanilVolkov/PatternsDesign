using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2VectorAndMatrix
{
    abstract class SomeMatrix : IMatrix
    {

        private object? matrix;
        public void AddColumn()
        {
            throw new NotImplementedException();
        }

        public void AddColumns(int count)
        {
            throw new NotImplementedException();
        }

        public void AddItem(object value)
        {
            throw new NotImplementedException();
        }

        public void AddRow()
        {
            throw new NotImplementedException();
        }

        public void AddRows(int count)
        {
            throw new NotImplementedException();
        }

        public int CountColumns()
        {
            throw new NotImplementedException();
        }

        public int CountRows()
        {
            throw new NotImplementedException();
        }

        public object GetItem(int row, int column)
        {
            throw new NotImplementedException();
        }
    }
}
