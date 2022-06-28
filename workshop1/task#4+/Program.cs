// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// РЕШЕНИЕ С ФУНКЦИЕЙ

Console.WriteLine("Введите первое целое число ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число ");
int third_number = Convert.ToInt32(Console.ReadLine());
int max;


if (first_number > second_number) 
{
    max = first_number;
}  
else 
{
    max = second_number;
}
if (third_number > max)
{
    Console.Write("Ответ: ");
    Console.WriteLine($"max из трех чисел = {third_number}");
}
else
{
    Console.Write("Ответ: ");
    Console.WriteLine($"max из трех чисел = {max}");
}
