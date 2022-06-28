// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Ура! {number} является четным числом!");
}
else
{
    Console.WriteLine($"Упс. {number} не является четным числом... Повезет в другой раз!");
}