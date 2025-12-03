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
            // [Коммит 4: Добавлена обработка ошибок и проверка входных данных] 
            // Блок try-catch для защиты от ввода текста вместо чисел
            try
            {
                // [Коммит 1: Начальная структура программы и ввод данных]
                Console.WriteLine("Введите координату x:");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите координату y:");
                double y = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите радиус r1:");
                double r1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите радиус r2:");
                double r2 = double.Parse(Console.ReadLine());

                // [Коммит 4: Добавлена обработка ошибок и проверка входных данных]
                // Проверка на корректность радиусов (не могут быть отрицательными)
                if (r1 < 0 || r2 < 0)
                {
                    Console.WriteLine("Ошибка: Радиус не может быть отрицательным.");
                    return;
                }

                //  [Коммит 2: Реализация расчетов расстояния и границ области] 
                double rMin = Math.Min(r1, r2);
                double rMax = Math.Max(r1, r2);

                double distanceSquared = x * x + y * y;
                double rMinSquared = rMin * rMin;
                double rMaxSquared = rMax * rMax;

                // [Коммит 3: Добавлена логика определения положения точки] 
                double epsilon = 0.000001;

                if (Math.Abs(distanceSquared - rMinSquared) < epsilon ||
                    Math.Abs(distanceSquared - rMaxSquared) < epsilon)
                {
                    Console.WriteLine("На границе");
                }
                else if (distanceSquared > rMinSquared && distanceSquared < rMaxSquared)
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
                }
            }
            //  [Коммит 4 (продолжение): Обработка ошибок]
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Пожалуйста, вводите только числа.");
            }

            Console.ReadLine();
        }
    }
}