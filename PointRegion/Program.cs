using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointRegion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Ввод данных
            Console.WriteLine("Введите координату x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус r1:");
            double r1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус r2:");
            double r2 = double.Parse(Console.ReadLine());

            // 2. Определяем границы (внутренний и внешний радиусы)
            // Пользователь мог ввести их в любом порядке
            double rMin = Math.Min(r1, r2);
            double rMax = Math.Max(r1, r2);

            // 3. Вычисляем квадрат расстояния от точки до (0,0)
            // x^2 + y^2
            double distanceSquared = x * x + y * y;

            // Квадраты радиусов для сравнения
            double rMinSquared = rMin * rMin;
            double rMaxSquared = rMax * rMax;

            Console.WriteLine($"Расстояние в квадрате: {distanceSquared}");
            Console.ReadLine();
        }
    }
}
