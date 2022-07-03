 /* Задача 4.Дано натуральное число, в котором все цифры различны. 
Определить, какая цифра расположена в нем левее: максимальная или минимальная. */

Console.WriteLine("Введите натуральное число, в котором все цифры различны");
string number = Console.ReadLine();
Console.WriteLine();
DopZadacha4(number);
Console.WriteLine();


void DopZadacha4(string arg)
{
    int index = 0;
    int maxElement = arg[index];
    int minElement = arg[index];
    int maxElementIndex = index;
    int minElementIndex = index;

    while (index < arg.Length)
    {
        if (arg[index] > maxElement)
        {
            maxElement = arg[index];
            maxElementIndex = index;
        }
        else if (arg[index] < minElement)
        {
            minElement = arg[index];
            minElementIndex = index;
        }
        index++;
    }
    // Console.WriteLine(maxElement);
    // Console.WriteLine(minElement);
    Console.WriteLine(maxElementIndex);
    Console.WriteLine(minElementIndex);
    if (maxElementIndex < minElementIndex)
    {
        Console.WriteLine($"Максимальная цифра расположена в числе левее минимальной"); 
    }
    else
    {
        Console.WriteLine($"Минимальная цифра расположена в числе левее максимальной"); 
    }
}