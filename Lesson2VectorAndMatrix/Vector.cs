namespace Lesson2VectorAndMatrix
{
    class Vector : IVector
    {
        private int[] vector;

        public int Length
        {
            get
            {
                return vector.Length;
            }
        }
        public Vector(int length)
        {
            vector = new int[length];
        }
        public Vector(int[] array)
        {

            vector = new int[array.Length];
            Array.Copy(array, 0, vector, 0, array.Length);
        }

        public void SetItem(int index, int value)
        {
            try
            {
                vector[index] = value;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"{index} was out of range. Must be non-negative and less than {vector.Length}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public int? GetItem(int index)
        {
            try
            {
                return vector[index];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"{index} was out of range. Must be non-negative and less than {vector.Length}.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
            
        }
    }
}
