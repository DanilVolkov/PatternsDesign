namespace Lesson2VectorAndMatrix
{
    class Vector : IVector
    {
        private List<int> vector;

        public int Count
        {
            get
            {
                return vector.Count;
            }
        }
        public Vector()
        {
            vector = new List<int>();
        }
        public Vector(List<int> list)
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
