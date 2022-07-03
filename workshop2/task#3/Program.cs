/* Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
Определить размер депозита через n месяцев. */

Console.WriteLine("Введите число, равное кол-ву месяцев вклада:");
double number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
DopZadacha3(number);
Console.WriteLine();


void DopZadacha3(double arg)
{
    int count = 1;
    double deposit = 1000;
    while (count <= arg)
    {
        deposit = deposit * 1.015;
        count++;
    }
    Console.WriteLine($"Вклад Ивана чараз {arg} мес. составит: {deposit}");
}