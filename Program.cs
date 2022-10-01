Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int leng = number.Length;

if (leng == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите Х координату; ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите У координату; ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z координату; ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите новый Х координату; ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите новый У координату; ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите новый Z координату; "); 
int z1 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x,2)+ Math.Pow(y1 - y,2)+ Math.Pow(z1 - z,2));
Console.WriteLine($"result = {result:f2}");

Напишите программу, которая принимает на вход число (N) и выдаё таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
int result = (int)Math.Pow(i,3);
Console.Write($"{result} ");

} 