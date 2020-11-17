using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaolo3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] niz = new string[3];
            Console.WriteLine("Upiši 1. string");
            niz[0] = Console.ReadLine();

            Console.WriteLine("Upiši 2. string");
            niz[1]= Console.ReadLine();

            Console.WriteLine("Upiši 3. string");
            niz[2] = Console.ReadLine();

            Array.Sort(niz);
            Array.Reverse(niz);

            Console.WriteLine("Razvrsteni stringovi : ");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine(niz[1]);
            }
            Console.ReadKey();
        }
    }
}
