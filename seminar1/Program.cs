void Zadacha2()
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

