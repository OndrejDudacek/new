using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                string vstup = Console.ReadLine();
                int cislo = 0;
                if (vstup == "n")
                {
                    break;
                }
                else
                {
                    cislo = int.Parse(vstup);
                }


                for (int i = 0; i < cislo; i++)
                {
                    Console.WriteLine("Cyklus" + (i + 1));
                }
            }

            



            Console.ReadKey();
        }
    }
}
