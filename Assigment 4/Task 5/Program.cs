int matrixsize = GetMatrixSize();

int[,] matrix = getMatrix(matrixsize);

int determinant = calculateDeterminant(matrixsize, matrix);

Console.WriteLine("You entered Matrix");
for(int i = 0; i < matrixsize; i++)
{
    for(int j = 0; j < matrixsize; j++)
    {
        Console.Write($"[{i},{j}]: " + matrix[i, j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Determinant is : {determinant}");


int GetMatrixSize()
{
    int matrixSize;
    do
    {
        Console.WriteLine("Choose Matrix Size 2 for 2x2, 3 For 3x3");
    } while(!int.TryParse(Console.ReadLine(), out matrixSize) && (matrixSize!=2 || matrixSize != 3));
    return matrixSize;
}
int[,] getMatrix(int matrixSize)
{
    int[,] matrix = new int[matrixSize,matrixSize];
    Console.WriteLine("Please enter values for Your Matrix");
    for (int i = 0; i < matrixSize; i++)
    {
        for(int j = 0; j < matrixSize; j++)
        {
            do
            {
                Console.Write($"Enter Value for element ({i}:{j}): ");
            } while(!int.TryParse(Console.ReadLine(),out matrix[i,j]));
        }
    }
    return matrix;
}
int calculateDeterminant(int matrixSize, int[,] matrix)
{
    int determinant = 0;
    if(matrixSize == 2)
    {
        determinant = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];
    }
    else if(matrixSize == 3)
    {
        for( int i = 0;i < matrixSize;i++)
        {
            determinant += matrix[0, i] * (matrix[1, (i + 1) % matrixSize] * matrix[2, (i + 2) % matrixSize] - matrix[1, (i + 2) % matrixSize] * matrix[2, (i + 1) % matrixSize]);
        }
    }
    else
    {
        Console.WriteLine("Error Counting Determinant");
    }
    return determinant;
}