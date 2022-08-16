void Zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.Write("Сколько хотите ввести чисел: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (number > 0) count++;
    }
    Console.WriteLine($"Было введено {count} число(а/ел) больше нуля");
}

void Zadacha43()
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    int k1 = 4;
    int k2 = 1;
    int b1 = 5;
    int b2 = 2;

    if (k1 == k2)
    {
        Console.WriteLine("Отсутствет точка пересечения, данные прямые параллельны");
    }

    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Координаты точки пересечения A ({Math.Round(x, 2)}, {Math.Round(y)})");
    }   

}

//Zadacha41();
//Zadacha43();