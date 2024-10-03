using Lesson2VectorAndMatrix;

Vector vector = new Vector();
vector.Add(5);
for (int i = 0; i < vector.Count; i++)
{
    Console.WriteLine(vector.Get(i));
}


List<int> indices = new List<int>() { 0, 1, 2, 3};
Vector vector_1 = new Vector(indices);
for (int i = 0; i < vector_1.Count; i++)
{
    Console.WriteLine(vector_1.Get(i));
}

SparseVector sparseVector_1 = new SparseVector();

SparseVector sparseVector_2 = new SparseVector(5);
Console.WriteLine(sparseVector_2.Count);
for (int i = 0; i < sparseVector_2.Count; i++)
{
    Console.WriteLine(sparseVector_2.Get(i));
}