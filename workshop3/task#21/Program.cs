/* **Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.WriteLine("Введите координаты AX:");
int AX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты AY:");
int AY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты AZ:");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BX:");
int BX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BY:");
int BY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты BZ:");
int BZ = Convert.ToInt32(Console.ReadLine());

Zadacha21(AX, AY, AZ, BX, BY, BZ);

void Zadacha21(int AX, int AY,int AZ, int BX, int BY, int BZ)
{
    double AB = Math.Sqrt(Math.Pow((BX - AX), 2) + Math.Pow((BY - AY), 2) + Math.Pow((BZ - AZ), 2));
    Console.WriteLine();
    Console.WriteLine($"Расстояние между точками А и В в 3D пространстве = {AB}");
    Console.WriteLine();
}
