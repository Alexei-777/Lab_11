using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_11;

namespace Lab_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie Lin = new Uravnenie();
            Lin.root();
            Console.WriteLine("Число x = " + Lin.x);
            Console.ReadKey();
        }
    }
}
