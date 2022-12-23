Console.WriteLine("Введите колличество строк");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение массива");
double min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение массива");
double max = int.Parse(Console.ReadLine()!);


double[,] mainMatrix = Create2DArray(m, n, min, max);
Print2DArray(mainMatrix);


double[,] Create2DArray(int m, int n, double min, double max)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble();
            matrix[i, j] = matrix[i, j] * (max - min) + min;
        }
    }
    return matrix;
}


void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(Math.Round(matrix[i, j], 1) + " ");
        }
        Console.WriteLine();
    }
}