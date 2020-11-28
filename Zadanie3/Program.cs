using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // program oblicza 1+2+3+ ... + n
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());
            
            int s = 0;

            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
