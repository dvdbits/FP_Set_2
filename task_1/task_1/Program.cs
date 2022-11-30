using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, res = 0;

            try {

                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");
                for(int i = 0; i < n; ++i)
                {
                    x = Convert.ToInt32(Console.ReadLine());

                    if(x % 2 == 0)
                    {
                        res++;
                    }

                }

                Console.WriteLine("In sir exista " + res + " numere pare" );
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog sa introduceti numere intregi!");
            }

            Console.ReadKey();
        }
    }
}
