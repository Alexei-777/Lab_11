using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Uravnenie
    {
        public double k;
        public double b;
        public double x;

        public void root()
        {
            Console.WriteLine("Введите число k = ");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b = ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0) { Console.WriteLine("Деление на 0, не возможно"); }
            else { x = -(b / k); }
        }

    }
}
