/* **Задача 47**. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
округлёнными до одного знака.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Zadacha47();
void Zadacha47()
{
    Console.WriteLine("Введите кол-во строк:");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите кол-во столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] matrix = new double[rows, columns];
    Console.WriteLine();
    PrintArrayDouble(matrix);
    FillArrayDouble(matrix);
    Console.WriteLine();
    Console.WriteLine("Массив, заполненный случайными вещественными числами:");
    Console.WriteLine();
    PrintArrayDouble(matrix);
    Console.WriteLine();
}

double[,] FillArrayDouble(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

/* **Задача 50.** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


Zadacha47(); // Вывод для пользователя: 0 ряд = 1 ряд, 0 строка = 1 строка.
void Zadacha47()
{

    Console.WriteLine();
    Console.WriteLine("Введите кол-во строк для создания массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите кол-во столбцов для создания массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Для поиска нужного элемента введите номер строки:");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Для поиска нужного элемента введите номер столбца:");
    int columnNumber = Convert.ToInt32(Console.ReadLine());

    int startNumber = 0; 
    int finishNumber = 10;
    int[,] matrix = new int[rows, columns];

    Console.WriteLine();
    FillArray(matrix, startNumber, finishNumber);
    PrintArray(matrix);
    Console.WriteLine();
    FindArrayElement(matrix, rowNumber, columnNumber);
}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    int rows = array.GetLength(0); 
    int columns = array.GetLength(1); 
    
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0); 
    int columns = array.GetLength(1); 

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindArrayElement(int [,] array, int rowNumber, int columnNumber)
{
    rowNumber--;
    columnNumber--;
    int rows = array.GetLength(0); 
    int columns = array.GetLength(1); 

    if (rowNumber < rows && columnNumber < columns)
    {
        Console.WriteLine();
        Console.WriteLine($"Значение элемента, находящегося в {rowNumber + 1}-й строке и {columnNumber + 1}-м столбце:");
        Console.WriteLine(array[rowNumber, columnNumber]);
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Такой позиции в массиве {rows} * {columns} не существует.");
        Console.WriteLine();
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


Zadacha52();
void Zadacha52()
{
    Console.WriteLine();
    Console.WriteLine("Введите кол-во строк для создания массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите кол-во столбцов для создания массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int startNumber = 0;
    int finishNumber = 10;
    int[,] matrix = new int[rows, columns];

    FillArray(matrix, startNumber, finishNumber);
    PrintArray(matrix);
    Console.WriteLine();
    FindColumnArithmeticMean(matrix);
    Console.WriteLine();
}

void FindColumnArithmeticMean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        double sum = 0;
        double count = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[j, i];
            count++;
        }
        Console.WriteLine($"Среднее арифметическое {i}-го столбца = {Math.Round(sum / count, 1)}");
    }
}

/* Задача 2. Двумерный массив 3х4 заполнен числами от 100 до 9999. 
Найдите в этом массиве и сохраните в одномерный массив числа, сумма цифр которых больше их произведения. 
Выведите оба массива.*/

Zadacha2();
void Zadacha2()
{
    Console.WriteLine();
    Console.WriteLine("Введите кол-во строк для создания массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите кол-во столбцов для создания массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int startNumber = 100;
    int finishNumber = 9999;
    int[,] matrix = new int[rows, columns];
    int[] resultArray = new int[matrix.Length];

    FillArray(matrix, startNumber, finishNumber);
    Console.WriteLine("Вывод двумерного массива: ");
    PrintArray(matrix);
    Console.WriteLine();
    DigitSumBiggerThanProduct(matrix, resultArray);
    Console.WriteLine();
    PrintArray2(resultArray);
    Console.WriteLine();

}

void FillArray(int[,] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] DigitSumBiggerThanProduct(int[,] array, int[] resultArray)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] < 1000)
            {
                if (((array[i, j] % 10) + ((array[i, j] / 10) % 10) + (array[i, j] / 100))
                > ((array[i, j] % 10) * ((array[i, j] / 10) % 10) * (array[i, j] / 100)))
                {
                    resultArray[index] = array[i, j];
                    index++;
                }
            }
            else if (array[i, j] > 1000)
            {
                if (((array[i, j] % 10) + ((array[i, j] / 10) % 10) + ((array[i, j] / 100) % 10) + (array[i, j] / 1000))
                > ((array[i, j] % 10) * ((array[i, j] / 10) % 10) * ((array[i, j] / 100) % 10) * (array[i, j] / 1000)))
                {
                    resultArray[index] = array[i, j];
                    index++;
                }
            }
        }
    }
    return resultArray;
}

void PrintArray2(int[] array)
{
    Console.WriteLine("Вывод одномерного массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}
