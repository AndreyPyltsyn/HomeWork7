Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение массива");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение массива");
int max = int.Parse(Console.ReadLine()!);


int[,] mainMatrix = Create2DArray(m, n, min, max);
Print2DArray(mainMatrix);
Console.WriteLine();
FindMeanArithmeticOfColum(mainMatrix, m);


int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMeanArithmeticOfColum(int[,] matrix, int m)
{
    int j = 0;
    while (j < m)
    {
        int summ = 0;
        double meanArithmetic = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }
        meanArithmetic = summ * 1.0 / m;
        Console.WriteLine(Math.Round(meanArithmetic, 1));
        j++;
    }
}