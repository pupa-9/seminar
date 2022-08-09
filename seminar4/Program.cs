void Zadacha25()
{
    //Задача 25: Используя определение степени числа, 
    //напишите цикл, который принимает на вход два натуральных 
    //числа (A и B) и возводит число A в степень B.
    Console.Write("Введите первое натуральное число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    if (A <= 0)
    {
        Console.WriteLine("Вы ввели ненатуральное число");
    }
    else
    {
        Console.Write("Введите второе натуральное число: ");
        int B = Convert.ToInt32(Console.ReadLine());  
        if (B <= 0)
        {
            Console.WriteLine("Вы ввели ненатуральное второе число");
        } 
        else
        {
            int result = 1;
            for (int i = 1; i <= B;)
            {
                result = result * A;
                i++;
            } 
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine ($"A в степени B = {result}");
        }
    }  
}

void Zadacha27()
    //Задача 27: Напишите программу, которая принимает 
    //на вход число и выдаёт сумму цифр в числе.
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while(num > 0)
    {
        sum += num%10;
        num /= 10;
    }
    Console.WriteLine(sum);
}

void Zadacha29()
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных 
    //целых чисел и выводит отсортированный по модулю массив.
{
    int size = 8;
    int[] array = new int[size];
    
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10,11);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
    for (int i = array.Length - 1; i > 0; i--)
    {
        for (int k = 0; k < i; k++)
        {
            if (Math.Abs(array[k]) > Math.Abs(array[k+1]))
            {
                int temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

//Zadacha25();
//Zadacha27();
//Zadacha29();
