using System.Collections.Generic;

namespace Lesson2VectorAndMatrix
{
    class SparseVector : IVector
    {
        private Dictionary<int, int> vector;

        public int Length
        {
            get
            {
                return vector.Count;
            }
        }
        public SparseVector()
        {
            vector = new Dictionary<int, int>();
        }
        public SparseVector(int[] array)
        {

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
            else
            {
                return null;
            }

        }
    }
}
