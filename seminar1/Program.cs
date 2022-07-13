void Zadacha2()
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
{
    int number_1 = 3;
    int number_2 = 5;

    if (number_1 > number_2)
    {
    Console.WriteLine("max = " + number_1);
    }
    else 
    {
    Console.WriteLine("max = " + number_2);
    }
}
//Zadacha2();

void Zadacha4()
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
{
    int number_1 = 2;
    int number_2 = 3;
    int number_3 = 7;
    int max = number_1;

    if (number_1 >= number_2)
    {
        if (number_1 >= number_3)
        Console.WriteLine(max);
        else
        {
            max = number_3;
            Console.WriteLine(max);
        }
    }
    else if (number_2 >= number_3)
    {
        max = number_2;
        Console.WriteLine(max);
    }
    else
    {
        max = number_3;
        Console.WriteLine(max);
    }
}
//Zadacha4();

void Zadacha6()
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
{
    int number = 4;
    if (number % 2 == 0) Console.WriteLine("Данное число является четным");
    else Console.WriteLine("Данное число является нечетным");
}
//Zadacha6();

void Zadacha8()
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
{
    int number = 7;
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0) Console.WriteLine(count);
        count++;
    }
}
//Zadacha8();