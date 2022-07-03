/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Zadacha15(number);
Console.WriteLine();

void Zadacha15(int arg)
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7 };
    
    if (arg == array[0]) Console.WriteLine("Понедельник");
    else if (arg == array[1]) Console.WriteLine("Вторник");
    else if (arg == array[2]) Console.WriteLine("Среда");
    else if (arg == array[3]) Console.WriteLine("Четверг");
    else if (arg == array[4]) Console.WriteLine("Пятница");
    else if (arg == array[5]) Console.WriteLine("Суббота");
    else if (arg == array[6]) Console.WriteLine("Воскресенье");

    if (arg == array[5] || arg == array[6])
    {
        Console.WriteLine("Ура! Это выходной день!");
    }
    else
    {
        Console.WriteLine("Увы. Идем на работу...");
    }
}