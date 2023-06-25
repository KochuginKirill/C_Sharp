void PrintMatrix(int[,] table)
{
    
    for(int rowStep = 0; rowStep < table.GetLength(0); rowStep++)
    {
         for(int columnStep = 0; columnStep < table.GetLength(1); columnStep++)
        {
            Console.Write($"{table[rowStep, columnStep]} ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixCreate(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns];
  for(int rowStep = 0; rowStep < rows; rowStep++)
    {
        for(int columnStep = 0; columnStep < columns; columnStep++)
        {
        matrix[rowStep, columnStep] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] matrixTest = MatrixCreate(3, 5, 1, 10);
PrintMatrix(matrixTest);






