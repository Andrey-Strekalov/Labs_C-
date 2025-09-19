using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_C_
{
    internal class Graph
    {
        public double a, b;

        public Graph()
        {

        }
        public Graph(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public Graph CreateGraphFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            return new Graph(aa, bb);
        }


        public static double Integral(double a, double b)
        {
            return (b * b - a * a) / 2.0;

        }
        public double Integral()
        {
            return (b * b - a * a) / 2.0;

        }



        public double CalculateSegmentLength(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public double CalculateSegmentLength()
        {
            return Math.Sqrt(a * a + b * b);
        }

        public void PrintInfo()
        {
            Console.WriteLine("       y");
            Console.WriteLine("       ^");
            Console.WriteLine("       │");
            Console.WriteLine("       │   *");
            Console.WriteLine("       │  *");
            Console.WriteLine("       │ *");
            Console.WriteLine("       │*");
            Console.WriteLine("───────────────-> x");
            Console.WriteLine("      *│");
            Console.WriteLine("     * │");
            Console.WriteLine("    *  │");
            Console.WriteLine("   *   │");
            Console.WriteLine();
            Console.WriteLine("Функция: y = x");
            Console.WriteLine($"Интеграл от {a} до {b}: {Integral(a, b)}");
            Console.WriteLine($"Длина отрезка: от ({a};{a}) до ({b};{b}): {CalculateSegmentLength(a, b)}");
        }

        public void PrintInfo(ConsoleColor bg, ConsoleColor fg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Clear();
            PrintInfo();
        }

        public void PrintInfo(double a, double b)
        {
            Console.WriteLine("       y");
            Console.WriteLine("       ↑");
            Console.WriteLine("       │");
            Console.WriteLine("       │   *");
            Console.WriteLine("       │  *");
            Console.WriteLine("       │ *");
            Console.WriteLine("       │*");
            Console.WriteLine("───────────────→ x");
            Console.WriteLine("      *│");
            Console.WriteLine("     * │");
            Console.WriteLine("    *  │");
            Console.WriteLine("   *   │");
            Console.WriteLine();
            Console.WriteLine("Функция: y = x");
            Console.WriteLine($"Интеграл от {a} до {b}: {Integral(a, b)}");
            Console.WriteLine($"Длина отрезка: от ({a};{a}) до ({b};{b}): {CalculateSegmentLength(a, b)}");
            Console.WriteLine(" ");
            Console.WriteLine($"Ряд значений функции и аргумента от {a} до {b}");
            Console.Write("y: ");
            double step = (b - a) / 10.0;
            for (double i = a; i <= b; i += step)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine(" ");
            Console.Write("x: ");
            for (double i = a; i <= b; i += step)
            {
                Console.Write(i + "  ");
            }
        }

    }
}