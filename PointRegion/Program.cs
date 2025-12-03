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

            Console.WriteLine("Данные получены. Нажмите Enter...");
            Console.ReadLine();
        }
    }
}
