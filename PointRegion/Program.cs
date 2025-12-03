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
            Console.WriteLine("Введите координату x:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус r1:");
            double r1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите радиус r2:");
            double r2 = double.Parse(Console.ReadLine());

            double rMin = Math.Min(r1, r2);
            double rMax = Math.Max(r1, r2);

            double distanceSquared = x * x + y * y;
            double rMinSquared = rMin * rMin;
            double rMaxSquared = rMax * rMax;

            // Точность для сравнения (погрешность double)
            double epsilon = 0.000001;

            // 4. Проверяем условия
            // Проверка: На границе
            if (Math.Abs(distanceSquared - rMinSquared) < epsilon ||
                Math.Abs(distanceSquared - rMaxSquared) < epsilon)
            {
                Console.WriteLine("На границе");
            }
            // Проверка: Внутри области (кольца)
            else if (distanceSquared > rMinSquared && distanceSquared < rMaxSquared)
            {
                Console.WriteLine("Да");
            }
            // Иначе: Вне области
            else
            {
                Console.WriteLine("Нет");
            }

            Console.ReadLine();
        }
    }
    }

