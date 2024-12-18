﻿namespace VisualizationMatrices
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
                throw new Exception($"{index} was out of range. Must be non-negative and less than {vector.Length}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public int GetItem(int index)
        {
            try
            {
                return vector[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new Exception($"{index} was out of range. Must be non-negative and less than {vector.Length}.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Vector Copy(Vector old_vector)
        {
            Vector vector = new Vector(old_vector.Length);
            for (int i = 0; i < old_vector.Length; i++)
            {
                vector.SetItem(i, vector.GetItem(i));
            }
            return vector;
        }
    }
}
