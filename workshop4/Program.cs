/* **Задача 25:**  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

// Решение с функцией: 

Zadacha25();

void Zadacha25()

{
    Console.WriteLine("Введите целое число:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое число:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {numberA} в степени {numberB } = {raisingToPower(numberA, numberB)}");
}

int raisingToPower(int arg1, int arg2)
{
    int sum = arg1;
    for (int i = 1; i < arg2; i++)
    {
        sum = sum * arg1;
    }
    return sum;
} 

// Решение с процедурой:

Zadacha25();

void Zadacha25()
{
    Console.WriteLine("Введите целое число:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое число:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    raisingToPower(numberA, numberB);
}

void raisingToPower(int arg1, int arg2)
{
    int sum = arg1;
    for (int i = 1; i < arg2; i++)
    {
        sum = sum * arg1;
    }
    Console.WriteLine($"Число {arg1} в степени {arg2} = {sum}");
}


/* **Задача 27:**  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12 */

// решение с процедурой:

Zadacha27();

void Zadacha27()
{
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
sumOfNumberDigits(number);
}

void sumOfNumberDigits(int number)
{
int digit = 0;
int sum = 0;
int originNumber = number;

while (number > 0)
    if (number <= 9)
    {
        sum = sum + number;
        number /= 10;
    }
    else
    {
        digit = number % 10;
        sum = sum + digit;
        number /= 10;
    }
Console.WriteLine($"Сумма цифр в числе {originNumber} = {sum}");
}

// решение с методом:

Zadacha27();

void Zadacha27()
{
Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {sumOfNumberDigits(number)}");
}

int sumOfNumberDigits(int number)
{
int digit = 0;
int sum = 0;

while (number > 0)
    if (number <= 9)
    {
        sum = sum + number;
        number /= 10;
    }
    else
    {
        digit = number % 10;
        sum = sum + digit;
        number /= 10;
    }
return sum;
}

/* **Задача 29:** Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33] */

Zadacha29();

void Zadacha29()
{
    int size = 8;
    int[] newArray = new int[size];
    fillArray(newArray);
    printArray(newArray);
    Console.WriteLine();
    sortArray(newArray);
    printArray(newArray);
}

void fillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-1000, 1000);
    }
}

void sortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minNumber = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minNumber]))
            {
                minNumber = j;
            }   
        }
        int temporary =  array[i];
        array[i] = array[minNumber];
        array[minNumber] = temporary;  
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// Решение через функцию:

Zadacha29();

void Zadacha29()
{
    int size = 8;
    int[] newArray = new int[size];

    fillArray(newArray);
    Console.WriteLine();
    Console.WriteLine($"Массив из {size} случайных чисел:");
    printArray(newArray);
    Console.WriteLine();
    Console.WriteLine();
    sortArray(newArray);
    Console.WriteLine($"Массив из {size} случайных чисел, отсортированный по модулю:");
    printArray(newArray);
    Console.WriteLine();
    Console.WriteLine();
}

int[] fillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-1000, 1000);
    }
    return array;
}

int [] sortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minNumber = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < Math.Abs(array[minNumber]))
            {
                minNumber = j;
            }   
        }
        int temporary =  array[i];
        array[i] = array[minNumber];
        array[minNumber] = temporary;  
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}