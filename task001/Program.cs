// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int [,] GenerateArray(int numLine, int numColumns, int minRandom = -10, int maxRandom = 20)
{
    int[,] matrix = new int[numLine, numColumns];
    for(int i = 0; i < matrix.GetLength(0); i++)  // Строка
    {
        for(int j = 0; j < matrix.GetLength(1); j++)  // Столбец
        {
            matrix[i,j] = new Random().Next(minRandom, maxRandom);
        }
         
    }
    return matrix;
}

void PrintArray(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }   
       System.Console.WriteLine();
    }
}
int numLine = Prompt("Введите количество строк");
int numColumns = Prompt("Введите количество столбцов");
int [,] matrix = GenerateArray(numLine, numColumns);
PrintArray(matrix);