using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать структуру для решения линейного уравнения 0=kx+b. Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
//Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie Lin = new Uravnenie();
            Lin.root();
            Console.WriteLine("Число x = " +Lin.x);
            Console.ReadKey();
        }
    }
}


struct Uravnenie
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
        if (b==0) { Console.WriteLine("Деление на 0, не возможно"); }
        else { x = -(b / k); }
    }

}
    

