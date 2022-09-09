//Задача 64: Задайте значения M и N. 
//Напишите рекурсионный метод, который выведет 
//все натуральные числа кратные 3-ём в промежутке от M до N.

void Zadacha64()
{
    Console.Write("Введите натуральное число M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"M = {M}, N = {N} ");

    while(M % 3 == 1|| M % 3 == 2) M++;

    for (int i = 0; i <= N; i += 3)
    {
        Console.Write($" {i + M}");
    }
}

//Задача 66: Задайте значения M и N. Напишите рекурсионный метод, 
//который найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66()
{
    Console.Write("Введи M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введи N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    if (M > 0 && N > 0)
    {
        if (M < N)
        {   
            for (int i = M; i <= N; i++)
            {
                sum = sum + i;
            }
        }
        else if (M == N) 
        {
            sum = sum + M;
        }
        else
        {
            for (int i = N; i <= M; i++)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
    }
    else Console.WriteLine("Вы ввели не натуральные числа");
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


//Zadacha64();
//Zadacha66();

