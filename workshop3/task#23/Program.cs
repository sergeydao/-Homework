/* **Задача 23** 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

Zadacha22(number);

void Zadacha22(int arg)
{
    int count = 1;
    Console.WriteLine();
    Console.WriteLine($"таблица кубов чисел от 1 до {arg}:");
    while (count <= arg)
    {
        Console.WriteLine(count * count * count);
        count++;
    }
    Console.WriteLine();
}