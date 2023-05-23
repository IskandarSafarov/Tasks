using System;
using System.Text;

class Program
{
    static void Main()
    {
       // Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Решение квадратного уравнения");
        Console.Write("Вводите a =");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Вводите b =");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Вводите c =");
        var c = double.Parse(Console.ReadLine());

        double x1, x2;
        var discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("Квадратное уравнение не имеет корней");
        }
        else
        {
            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            Console.WriteLine($"x1 = {x1}; x2 = {x2}");
        }
    }
}