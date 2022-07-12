/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Zadacha34();
void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];
    int firsNumber = 100;
    int secondNumber = 999;
    Console.WriteLine();
    fillArray(array, firsNumber, secondNumber);
    printArray(array);
    Console.WriteLine();
    sortArray(array);
    Console.WriteLine();
}

int[] fillArray(int[] array, int firsNumber = 0, int secondNumber = 0)
{
    secondNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(firsNumber, secondNumber);
    }
    return array;
}

void sortArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во чётных чисел в массиве = {count}");
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Zadacha36();
void Zadacha36()
{
    Random rand = new Random();
    int size = rand.Next(5, 10);
    int[] array = new int[size];
    int firsNumber = 1;
    int secondNumber = 10;
    Console.WriteLine();
    fillArray(array, firsNumber, secondNumber);
    printArray(array);
    Console.WriteLine();
    sortArray(array);
    Console.WriteLine();
    Console.WriteLine();
}

int[] fillArray(int[] array, int firsNumber = 0, int secondNumber = 0)
{
    secondNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(firsNumber, secondNumber);
    }
    return array;
}

void sortArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Zadacha38();
void Zadacha38()
{
    Random rand = new Random();
    int size = rand.Next(5, 10);
    double[] array = new double[size];
    int firsNumber = 1;
    int secondNumber = 100;
    Console.WriteLine();
    fillArray(array, firsNumber, secondNumber);
    printArray(array);
    Console.WriteLine();
    Console.WriteLine();
    sortArray(array);
    Console.WriteLine();
}

double[] fillArray(double[] array, int firsNumber = 0, int secondNumber = 0)
{
    secondNumber++;
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(firsNumber, secondNumber) + rand.NextDouble();
    }
    return array;
}

double findMaxNumber(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double findMinNumber(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

void sortArray(double[] array)
{
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(findMaxNumber(array) - findMinNumber(array), 2)}");
}


void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 2) + " ");
    }
}