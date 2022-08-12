void Zadacha34()
{   //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    Random random = new Random();
    int size = random.Next(5,11);
    int[] array = new int [size];
    FillArray(array, 100, 999);
    PrintArray(array);

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечётных позициях.
    Random random = new Random();
    int size = random.Next(5,11);
    int[] array = new int [size];
    FillArray(array, 0, 10);
    PrintArray(array);

    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
}

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.
    Random random = new Random();
    int size = random.Next(5,11);
    double[] array = new double [size];
    FillArrayDouble(array, 100, 100000);
    PrintArrayDouble(array);

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Разница между минимальным элементом {min} и максимальным {max} равна {max - min}");
}

void FillArray(int[] array, int starNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(starNumber, finishNumber);
    }
}

void FillArrayDouble(double[] array, int starNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 10 - 5,2);
    }
}

void PrintArray(int[] array, int starNumber = -10, int finishNumber = 10)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

void PrintArrayDouble(double[] array, int starNumber = -10, int finishNumber = 10)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

//Zadacha34();
//Zadacha36();
//Zadacha38();