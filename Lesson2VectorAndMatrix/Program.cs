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

Console.WriteLine();
Console.WriteLine("Matrix");

Matrix matrix = new Matrix(3, 2);
try
{
    Console.WriteLine(matrix.GetItem(4, 1));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


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

Console.WriteLine();
Console.WriteLine("SparseMatrix");


SparseMatrix sparseMatrix = new SparseMatrix(3, 2);
Console.WriteLine(sparseMatrix.GetItem(2, 1));

try
{
    Console.WriteLine(sparseMatrix.GetItem(4, 1));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();

List<SparseVector> sparseVector1 = new List<SparseVector>() { new SparseVector(3), new SparseVector(3), new SparseVector(3) };

SparseMatrix sparseMatrix1 = new SparseMatrix(sparseVector1);

sparseMatrix1.SetItem(1, 2, 19);
sparseMatrix1.SetItem(2, 1, 5);
sparseMatrix1.SetItem(0, 0, 3);
sparseMatrix1.SetItem(0, 2, 100);
sparseMatrix1.SetItem(1, 1, 78);
sparseMatrix1.SetItem(2, 1, 34);
sparseMatrix1.SetItem(2, 2, 54);
sparseMatrix1.SetItem(2, 0, 93);

for (int i = 0; i < sparseMatrix1.CountRows; i++)
{
    for (int j = 0; j < sparseMatrix1.CountColumns; j++)
    {
        Console.Write($"{sparseMatrix1.GetItem(i, j)} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("InitMatrix");
matrix = new Matrix(3, 3);
InitMatrix.FillMatrix(matrix, 5, 10);
for (int i = 0; i < matrix.CountRows; i++)
{
    for (int j = 0; j < matrix.CountColumns; j++)
    {
        Console.Write($"{matrix.GetItem(i, j)} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("InitSparseMatrix");
sparseMatrix = new SparseMatrix(3, 3);
InitMatrix.FillMatrix(sparseMatrix, 5, 10);
for (int i = 0; i < sparseMatrix.CountRows; i++)
{
    for (int j = 0; j < sparseMatrix.CountColumns; j++)
    {
        Console.Write($"{sparseMatrix.GetItem(i, j)} ");
    }
    Console.WriteLine();
}








