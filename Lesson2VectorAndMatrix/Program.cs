using Lesson2VectorAndMatrix;

Console.WriteLine("Vector");

Vector vector = new Vector(3);

Console.WriteLine(vector.Length);

vector.SetItem(0, 0);
vector.SetItem(2, 5);
vector.SetItem(1, 6);

for (int i = 0; i < vector.Length; i++)
{
    Console.WriteLine(vector.GetItem(i));
}

int[] array = new int[] { 0, 5, 2, 3, 4, 5, 0, 0, 0 };

SparseVector sparseVector = new SparseVector(array);

Console.WriteLine("\nSparseVector");
Console.WriteLine(sparseVector.Length);
Console.WriteLine();

for (int i = 0; i < sparseVector.Length; i++)
{
    Console.WriteLine(sparseVector.GetItem(i));
}

Console.WriteLine();

sparseVector.SetItem(8, 100);
for (int i = 0; i < sparseVector.Length; i++)
{
    Console.WriteLine(sparseVector.GetItem(i));
}




