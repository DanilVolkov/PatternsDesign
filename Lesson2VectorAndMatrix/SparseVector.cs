using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2VectorAndMatrix
{
    class SparseVector : IVector
    {
        private List<int> vector;

        public int Count
        {
            get
            {
                return vector.Count;
            }
        }

        public SparseVector()
        {
            vector = new List<int>();
        }

        public SparseVector(int count)
        {
            vector = new List<int>(Enumerable.Range(0, count).Select(x => 0));
        }
        public SparseVector(List<int> list)
        {
            vector = new List<int>(list);
        }

        public void Add(int value)
        {
            vector.Add(value);
        }

        public object Get(int index)
        {
            if (index >= 0 && index < vector.Count)
            {
                return vector[index];
            }
            else
            {
                return $"{index} was out of range. Must be non-negative and less than {vector.Count}.";
            }

        }
    }
}
