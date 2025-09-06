using System;

namespace Labs_C_
{
    internal class LineSegment
    {
        private double x0, y0, x, y;
        private double Length;

        public void Load()
        {

            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
        }
        public double GetLength() { return Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2)); }
        public double GetDistanceToStart() { return Math.Sqrt(Math.Pow(x0, 2) + Math.Pow(y0, 2)); }
        public double GetDistanceToEnd() { return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); }
        public void PrintInfo()
        {
            Console.WriteLine("Объект <<отрезок>>");
            Console.WriteLine($"Длина отрезка {GetLength()}");
            Console.WriteLine($"Координаты начала: ({x0};{y0})");
            Console.WriteLine($"Координаты конца: ({x};{y})");
            Console.WriteLine("Расстояние от начала координат до: ");
            Console.WriteLine($"Начала отрезка {GetDistanceToStart()}");
            Console.WriteLine($"Конца отрезка {GetDistanceToEnd()}");
        }

    }
}
