using System.Collections.Generic;

namespace Lesson2VectorAndMatrix
{
    class SparseVector : IVector
    {
        private Dictionary<int, int> vector;

        private int countElements;

        public int Length
        {
            get
            {
                return countElements;
            }
        }
        public SparseVector(int count)
        {
            vector = new Dictionary<int, int>();
            countElements = count;
        }
        public SparseVector(int[] array)
        {
            countElements = array.Length;
            vector = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    vector.Add(i, array[i]);
                }
            }
        }

        public SparseVector(List<int> list)
        {
            countElements = list.Count;
            vector = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0)
                {
                    vector.Add(i, list[i]);
                }
            }
        }

        public void SetItem(int index, int value)
        {
            if (!vector.ContainsKey(index))
            {
                vector.Add(index, value);
            }
        }

        public int? GetItem(int index)
        {
            if (vector.ContainsKey(index))
            {
                return vector[index];
            }
            else if (index >= 0 && index < this.Length)
            {
                return 0;
            }
            else
            {
                return null;
            }

        }
    }
}
