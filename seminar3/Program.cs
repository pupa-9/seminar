// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Задача 17. Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка.
void Zadacha17()
{
    Random random = new Random();
    int x = random.Next(-10,11);
    int y = random.Next(-10,11);
    Console.WriteLine($"точка с координатами ({x}, {y})");
    if (x > 0 && y > 0) Console.WriteLine("1 четверть");
    else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
    else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
    else Console.WriteLine("Точка лежит на оси координат");
}
//Zadacha17();
/*
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    Console.WriteLine("Вторая цифра числа: " + (number % 100 / 10));
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
*/

void Zadacha19()
//Задача 19: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.
{
    Console.WriteLine("Задачка");
}
//Zadacha19();

void Zadacha21()
// Задача 21: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
{
    Console.WriteLine("Введите координаты первой точки");
    Console.WriteLine("x: ");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y: ");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z: ");
    double z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки");
    Console.WriteLine("x: ");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y: ");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z: ");
    double z2 = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Координаты первой точки ({x1}, {y1}, {z1})" + " ");
    Console.WriteLine($"и координаты второй точки ({x2}, {y2}, {z2})");
    double dist = 0;

    dist = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    dist = Math.Round(dist, 3);
    Console.WriteLine($"Расстояние между точками равно ({dist})");
}
//Zadacha21();

// Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Zadacha23()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    if (count > number)
    {
        Console.WriteLine($"Вы ввели число {number}, которое меньше 1");
    }
    else while  (count <= number)
    {
        Console.WriteLine($"{count} => " + Math.Pow(count,3));
        count++;
    }
    
    /*else
    {
        Console.WriteLine($"Вы ввели число {number}, которое меньше 1");
    }
    */
}
//Zadacha23();

