/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите положительное целое число");
string number = Console.ReadLine();
Zadacha13(number);


void Zadacha13(string arg)
{
    if (arg.Length < 3)
    {
        Console.WriteLine("Число состоит из двух цифр");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {arg} = {arg[2]}");
    }
}