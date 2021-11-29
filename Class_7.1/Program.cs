using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника в м: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треугольника в м: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            double P1, S1;
            GetParam1(x1, y1, z1, out P1, out S1);
            double P2, S2;
            GetParam2(x2, y2, z2, out P2, out S2);
            Console.WriteLine("Площадь первого треугольника: {0:F3} м2", S1);
            Console.WriteLine("Площадь второго треугольника: {0:F3} м2", S2);
            if (S1 > S2)
            {
                Console.WriteLine("Максимальная площадь у первого треугольника: {0:F3} м2", S1);
            }
            if (S2 > S1)
            {
                Console.WriteLine("Максимальная площадь у второго треугольника: {0:F3} м2", S2);
            }
            Console.ReadKey();
        }
        static void GetParam1(int x1, int y1, int z1, out double P1, out double S1)
        {
            P1 = (x1+y1+z1)/2;
            S1 = Math.Sqrt(P1 *(P1-x1)*(P1-y1)*(P1-z1));
        }
        static void GetParam2(int x2, int y2, int z2, out double P2, out double S2)
        {
            P2 = (x2 + y2 + z2) / 2;
            S2 = Math.Sqrt(P2 * (P2 - x2) * (P2 - y2) * (P2 - z2));
        }
    }
}
