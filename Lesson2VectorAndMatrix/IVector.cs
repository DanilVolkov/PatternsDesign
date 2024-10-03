namespace Lesson2VectorAndMatrix
{
    interface IVector
    {
        public int Count { get; }
        void Add(int value);

        object Get(int index);
    }
}
