int[,] field10x15 = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};


void Tetris(int[,] field)
{   
       for(int i = 0; i < field.GetLength(0); i++)
    {
        for(int j = 0; j < field.GetLength(1); j++)
        {
            if(field[i,j] == 0) Console.Write($"-");
            else Console.Write($"o");
        }
        Console.WriteLine();
    }
}
 
 int[,] iShape = new int[,]
    {
        {1},
        {1},
        {1},
        {1},
    };

int [,] rotate(int[,] input)
{
    int newColumns = input.GetLength(0);
    int newRows = input.GetLength(1);
    int[,] newMatrix = new int[newRows, newColumns];
    for(int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i,j] = input[j, i];
        }
    }

    return newMatrix;
}

Tetris(iShape);
int[,] iShapeRotate = rotate(iShape);
Tetris(iShapeRotate);

