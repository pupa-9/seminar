﻿void Zadacha54()
//Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.
{
    int rows = 5;
    int columns = 6;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = columns - 1; j > 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(array);
}

void Zadacha56()
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
{
    int rows = 5;
    int columns = 6;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    int min = array[0, 0];
    int sumMin = FirstSum(array);
    int indexMin = 0;
    Console.WriteLine($"Сумма элементов {indexMin + 1} строки равна {sumMin}");

    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки равна {sum}");
        if (sum < sumMin) 
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"минимальная сумма находится в строке {indexMin + 1} и равна {sumMin}");
}

int FirstSum(int[,] array)
{
    int sum = 0;
    int columns = array.GetLength(1);
    for (int j = 0; j < columns; j++) sum += array[0,j];
    return sum;
}

void Zadacha58()
//Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    int row = 0;
    int column = 0;
    int changeRow = 0;
    int changeColumn = 1;
    int steps = columns;
    int turn = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[row,column] = i + 1;
        steps--;
        //Console.Write(array[row,column] + "  ");
        if (steps == 0)
        {
            steps = rows - 1 - turn/2;
            int temp = changeRow;
            changeRow = changeColumn;
            changeColumn = -temp;
            turn++;
        }

        row += changeRow;
        column += changeColumn;
    }
    PrintArray(array);
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
//Zadacha54();
//Zadacha56();
//Zadacha58();