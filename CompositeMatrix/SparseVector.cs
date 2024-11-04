using System.Collections.Generic;

namespace CompositeMatrix
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
            else
            {
                vector[index] = value;
            }
        }

        public int GetItem(int index)
        {
            try
            {
                if (!vector.ContainsKey(index) && index >=0 && index < this.Length)
                {
                    return 0;
                }
                
                    
                return vector[index];
            }
            catch (KeyNotFoundException)
            {
                throw new Exception($"{index} was out of range. Must be non-negative and less than {this.Length}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public SparseVector Copy(SparseVector old_vector)
        {
            SparseVector vector = new SparseVector(old_vector.Length);
            for (int i = 0; i < old_vector.Length; i++)
            {
                vector.SetItem(i, vector.GetItem(i));
            }
            return vector;
        }
    }
}
