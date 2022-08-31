// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int [,] GenerateArray(int numLine, int numColumns, int minRandom, int maxRandom)
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

bool CheckIndexes(int[,] array, int line, int column)
{
    bool result = true;
    if (array.GetLength(0) <= line || array.GetLength(1) <= column)
    {
        result = false;
    }
    return result;
}

void FindElement(int[,] array, int line, int column) 
{
    if (CheckIndexes(array, line, column))  
    {
        System.Console.Write(array[line, column]);
    }
    else
    {
        System.Console.Write("Такого элемента нет");
    }
}


int [,] matrix = GenerateArray(3,3,1,10);
PrintArray(matrix);
FindElement(matrix, Prompt("Введите индекс строки > "), Prompt("Введите индекс столбца > "));