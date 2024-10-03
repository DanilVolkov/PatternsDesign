namespace Lesson2VectorAndMatrix
{
    interface IVector
    {
        public int Length { get; }

        void SetItem(int index, int value);

        int? GetItem(int index);
    }
}
