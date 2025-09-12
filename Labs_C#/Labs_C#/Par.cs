using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_C_
{
    internal class Par
    {
        private double a, b, c;
        private Par() { }
        public Par(double pA, double pB, double pC)
        {
            a = pA;
            b = pB;
            c = pC;
        }
        public static Par CreateParFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            double cc = Convert.ToDouble(Console.ReadLine());
            return new Par(aa, bb, cc);
        }
        public double GetV() { return a * b * c; }
        public double GetS() { return 2 * (a * b + b * c + c * a); }
        public void Info()
        {
            String str =
            "******************************\n" +
            "*                            *\n" +
            "*       параллелепипед       *\n" +
            "*                            *\n" +
            "******************************\n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("A = {0:0.00}, B = {1:0.00}, C = {2:0.00}", a, b, c));
            Console.WriteLine(string.Format("V = {0:0.00}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
        }
        public void Info(ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.Clear();
            Info();
        }
        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
        }
    }
}