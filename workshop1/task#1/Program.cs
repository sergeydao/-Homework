/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое целое число ");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number == second_number) // теоретически, можно ввести и одинаковые числа)) А так эту строку можно убрать.
{
    Console.Write("Ответ: ");
    Console.WriteLine($"{first_number} и {second_number} равны");
}
else if (first_number > second_number)
{
    Console.WriteLine("Ответ: ");
    Console.WriteLine($"max из двух чисел = {first_number}");
    Console.WriteLine($"min из двух чисел = {second_number}");
}
else
{
    Console.WriteLine("Ответ: ");
    Console.WriteLine($"max из двух чисел = {second_number}");
    Console.WriteLine($"min из двух чисел = {first_number}");
}