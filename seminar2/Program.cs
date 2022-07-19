void Zadacha10()
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
        if (number < 1000 && number > 99)
    {
        Console.WriteLine("Вторая цифра числа: " + (number % 100 / 10));
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число");
    }
}
//Zadacha10();

void Zadacha13()
// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    int number = 645;
    number = Math.Abs(number);
    if (number < 100)
    {
        Console.WriteLine("В данном числе менее 3 символов");
    }
    else
    {
        while(number > 999)
        {
            number /= 10;  
        }
        Console.WriteLine(number%10);
    }
}
//Zadacha13();

void Zadacha15()
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    Console.WriteLine("Введите число дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Этот день является выходным");
    }
    else if (day >= 1 && day <= 5)
    {
        Console.WriteLine("Этот день не является выходным");
    }
    else
    {
        Console.WriteLine("Некорретный ввод");
    } 
}
//Zadacha15();