using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: "); // użytkownik podaje lewy kraniec przedziału
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: "); // użytkownik podaje prawy kraniec przedziału
            int b = int.Parse(Console.ReadLine());

            int i = a;

            while (i <= b)
            {
                if (i % 2 == 0) Console.Write("{0} ", i);

                i++;
            }

            Console.ReadKey();
        }
    }
}
