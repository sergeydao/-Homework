// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Zadacha54();
void Zadacha54()
{
    Console.WriteLine();
    Console.WriteLine("Введите кол-во строк для создания массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите кол-во столбцов для создания массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int startNumber = 0;
    int finishNumber = 9;
    int[,] matrix = new int[rows, columns];

    FillArray(matrix, startNumber, finishNumber);
    PrintArray(matrix);
    Console.WriteLine();
    SortArray(matrix);
    PrintArray(matrix);
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
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1 - j; k++) 
            {
                if (array[i, k] < array[i, k + 1] )
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Zadacha56();
void Zadacha56()
{
    Console.WriteLine();
    Console.WriteLine("Введите кол-во строк для создания массива:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите кол-во столбцов для создания массива:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int startNumber = 0;
    int finishNumber = 9;
    int[,] matrix = new int[rows, columns];

    FillArray(matrix, startNumber, finishNumber);
    PrintArray(matrix);
    Console.WriteLine();
    FindRowWithMinimumSum(matrix);
    Console.WriteLine();
}

void FindRowWithMinimumSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = 0;
    int minSumIndex = 0;

    for (int j = 0; j < columns; j++)
    {
        minSum += array[0, j];
    }

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
    }
    Console.WriteLine($"Строка с мин. суммой элементов №{minSumIndex + 1}, сумма элементов {minSum}"); // вывод для пользователя.
}