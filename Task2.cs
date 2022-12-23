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
FindNumberArray(mainMatrix);


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

void FindNumberArray(int[,] matrix)
{
    Console.WriteLine("Введите номер строки");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер столбца");
    int n = int.Parse(Console.ReadLine()!);
    if (m < matrix.GetLength(0) || n < matrix.GetLength(1))
    {
        Console.WriteLine("Значение элемента = " + matrix[m, n]);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}