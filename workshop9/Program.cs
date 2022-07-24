// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Zadacha68();
void Zadacha68()
{
    Console.WriteLine("Введите целое неотрицательное число m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое неотрицательное число n:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m >= 0 && n >= 0)
    {
        Console.WriteLine();
        Console.WriteLine($" A ( m , n ) = {Ack(m, n)}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Вы ввели неверные числа.");
        Console.WriteLine();
    }
    
}

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ack(m - 1, 1);
    }
    else
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}


/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N, кратные трём. */

int numberM = -12;
int numberN = 10;

Zadacha(numberM, numberN);

void Zadacha(int numberM, int numberN)
{
    while (numberM <= numberN)
    {
        if (numberM != 0 && numberM % 3 == 0)
        {
            Console.Write(numberM + "\t");
        }
        numberM++;
    }
    Console.WriteLine();

}

Recursion(numberM, numberN);
Console.WriteLine();

void Recursion(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    else if (numberM != 0 && numberM % 3 == 0)
    {
        Console.Write(numberM + "\t");
    }
    numberM++;
    Recursion(numberM, numberN);
}

// как вариант:
Recursion2(numberM, numberN); // условие: numberM кратно 3.
Console.WriteLine();

void Recursion2(int numberM, int numberN)
{
    if (numberM != 0 && numberM > numberN)
    {
        return;
    }
    Console.Write(numberM + "\t");
    numberM += 3;

    Recursion(numberM, numberN);
}

/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. */

int numberM = 3;
int numberN = 9;

Zadacha66(numberM, numberN);

void Zadacha66(int numberM, int numberN)
{
    int sum = 0;
    while (numberM <= numberN)
    {
        sum += numberM;
        numberM++;
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {sum}");
    Console.WriteLine();
}

Recursion66(numberM, numberN);

void Recursion66(int numberM, int numberN, int sum = 0)
{
    if (numberM > numberN)
    {
        Console.WriteLine();
        Console.WriteLine($"Сумма натуральных элементов в заданном промежутке равна {sum}");
        Console.WriteLine();
        return;
    }
    sum += numberM;
    numberM++;
    Recursion66(numberM, numberN, sum);
}
