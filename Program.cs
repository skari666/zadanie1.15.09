using System;

class Program
{
    static void Main()
    {
        Console.WriteLine('Введите координаты точки A:');
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine('Введите координаты точки B:');
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($'Длина отрезка AB = {distance:F3}');
    }
}
