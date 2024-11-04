using CompositeMatrix;

Console.WriteLine("Matrix 1:");
Matrix matrix1 = new Matrix(2, 2);
//InitMatrix.FillMatrix(matrix1, 5, 10);
InitMatrixValue(matrix1, 1);
PrintMatrix(matrix1);

Console.WriteLine("Matrix 2:");
Matrix matrix2 = new Matrix(3, 3);
InitMatrixValue(matrix2, 2);
PrintMatrix(matrix2);

Console.WriteLine("SparseMatrix 3:");
SparseMatrix matrix3 = new SparseMatrix(5, 1);
InitMatrixValue(matrix3, 3);
PrintMatrix(matrix3);

Console.WriteLine("SparseMatrix 4:");
SparseMatrix matrix4 = new SparseMatrix(1, 1);
InitMatrixValue(matrix4, 4);
PrintMatrix(matrix4);

Console.WriteLine("SparseMatrix 5:");
SparseMatrix matrix5 = new SparseMatrix(2, 4);
InitMatrixValue(matrix5, 5);
PrintMatrix(matrix5);

Console.WriteLine("Matrix 6:");
Matrix matrix6 = new Matrix(2, 3);
InitMatrixValue(matrix6, 6);
PrintMatrix(matrix6);

Console.WriteLine("Matrix 7:");
Matrix matrix7 = new Matrix(2, 1);
InitMatrixValue(matrix7, 7);
PrintMatrix(matrix7);

Console.WriteLine("Matrix group 1:");
HGroupMatrices matrix_group1 = new HGroupMatrices(matrix1, matrix2, matrix3);
matrix_group1.AddMatrix(matrix4);
PrintMatrix(matrix_group1);

Console.WriteLine("Matrix group 2:");
HGroupMatrices matrix_group2 = new HGroupMatrices(matrix5, matrix6);
PrintMatrix(matrix_group2);

Console.WriteLine("Matrix group 3:");
HGroupMatrices matrix_group3 = new HGroupMatrices(matrix_group1, matrix_group2, matrix7);
PrintMatrix(matrix_group3);


matrix_group1.SetItem(1, 3, 5);
Console.WriteLine("Matrix group 1 modify:");
PrintMatrix(matrix_group1);

matrix_group3.SetItem(0, 10, 0);
matrix_group3.SetItem(1, 10, 0);
Console.WriteLine("Matrix group 3 modify:");
PrintMatrix(matrix_group3);

Console.WriteLine("Matrix group 4:");
VGroupMatrices matrix_group4 = new VGroupMatrices(matrix_group1, matrix_group2);
PrintMatrix(matrix_group4);

Console.WriteLine("Matrix group 4 modify:");
matrix_group4.AddMatrix(matrix7);
PrintMatrix(matrix_group4);


void InitMatrixValue(IMatrix matrix, int value)
{
    for (int i = 0; i < matrix.CountRows; i++)
        for (int j = 0; j < matrix.CountColumns; j++)
            matrix.SetItem(i, j, value);
}

void PrintMatrix(IMatrix matrix)
{
    for (int i = 0; i < matrix.CountRows; i++)
    {
        for (int j = 0; j < matrix.CountColumns; j++)
        {
            if (matrix.GetItem(i, j) == -1)
                Console.Write("  ");
            else
                Console.Write($"{matrix.GetItem(i, j)} ");              
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



