using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            // s = 1 + 2 + 3 + ... + 10
            int i = 1;
            int s = 0;

            while (i<=10)
            {
                Console.WriteLine("Przebieg pętli nr: {0}", i);
                s = s + i;
                i = i + 1;
                Console.WriteLine("Po zakończeniu pętli: i= {0}, s={1}", i,s);
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
