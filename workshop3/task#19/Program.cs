/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
Console.WriteLine();
Zadacha19(number);
Console.WriteLine();

void Zadacha19 (string array)
{
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.WriteLine($"Число {array} является палиндромом.");
    }
    else
    {
       Console.WriteLine($"Число {array} не является палиндромом."); 
    } 
}
