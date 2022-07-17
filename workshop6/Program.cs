/* **Задача 41:** Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Zadacha41();

void Zadacha41()
{
    Console.WriteLine();
    Console.WriteLine("Введите кол-во цифр, которые Вы хотите ввести:");
    int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    CountPositiveInteger(amountOfNumbers);
    Console.WriteLine();
}

void CountPositiveInteger(int amountOfNumbers)
{
    int count = 0;
    for (int i = 1; i <= amountOfNumbers; i++)
    {
        Console.WriteLine($"Введите число №{i}:");
        int digit = Convert.ToInt32(Console.ReadLine());
        if (digit > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Чисел больше нуля: {count}.");
}


/* **Задача 43:** Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Zadacha43();
void Zadacha43()
{
    Console.WriteLine();
    Console.WriteLine("Введите значение b1:");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение k1:");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение b2:");
    double b2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение k2:");
    double k2 = Convert.ToDouble(Console.ReadLine());

    FindLinesCrossingPoint(b1, k1, b2, k2);
}

void FindLinesCrossingPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine();
    Console.WriteLine($"Точка пересечения по оси x: {x}");
    Console.WriteLine($"Точка пересечения по оси y: {y}");
    Console.WriteLine();
}