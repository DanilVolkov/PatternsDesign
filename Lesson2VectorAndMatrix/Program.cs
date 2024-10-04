using Lesson2VectorAndMatrix;
using System.Runtime.ExceptionServices;

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

Console.WriteLine();
Console.WriteLine("Matrix");

Matrix matrix = new Matrix(3, 2);
Console.WriteLine(matrix.GetItem(4, 1));

List<Vector> vector_1 = new List<Vector>() { new Vector(3), new Vector(3), new Vector(3) };

Matrix matrix_1 = new Matrix(vector_1);

matrix_1.SetItem(1, 2, 19);
matrix_1.SetItem(2, 1, 5);
matrix_1.SetItem(0, 0, 3);
matrix_1.SetItem(0, 2, 100);
matrix_1.SetItem(1, 1, 78);
matrix_1.SetItem(2, 1, 34);
matrix_1.SetItem(2, 2, 54);
matrix_1.SetItem(2, 0, 93);

for (int i = 0; i < matrix_1.CountRows; i++)
{
    for (int j = 0; j < matrix_1.CountColumns; j++)
    {
        Console.Write($"{matrix_1.GetItem(i, j)} ");
    }
    Console.WriteLine();
}





