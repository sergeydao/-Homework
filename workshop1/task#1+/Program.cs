// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// РЕШЕНИЕ С ФУНКЦИЕЙ:

int MaxNumber(int number1, int number2)
{
    int max;
    if (number1 > number2)
    {
        max = number1;
    }
    else
    {
        max = number2;
    }
    return max; 
    
}

int MinNumber(int number1, int number2)
{
    int min;
    if (number1 > number2)
    {
        min = number2;
    }
    else
    {
        min = number1;
    }
    return min; 
    
}


Console.WriteLine("Введите первое целое число ");
int first_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int second_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($" max из двух чисел = {MaxNumber(first_number, second_number)}");
Console.WriteLine($" min из двух чисел = {MinNumber(first_number, second_number)}");
