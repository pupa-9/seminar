void Zadacha47()
//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] array = new double[rows, columns];
    FillArrayDouble(array);
    PrintArrayDouble(array);
}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 10)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    finishNumber++;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void FillArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}

void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}

void Zadacha50()
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    Random random = new Random();
    int rows = random.Next(2, 4);
    int columns = random.Next(2, 4);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 1000);
    PrintArray(array);

    Console.WriteLine("Введите номер столбца");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер строки");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row <= rows && row > 0 && column <= columns && column > 0)
    {
        Console.WriteLine($"Искомый элемент {array[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine("Элемента не существует");
    }
    
}

void Zadacha52()
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
{
    Random random = new Random();
    int rows = 3;
    int columns = 5;
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        Console.Write(Math.Round(sum/rows, 2) + "\t");
    }
}


//Zadacha47();
//Zadacha50();
//Zadacha52();