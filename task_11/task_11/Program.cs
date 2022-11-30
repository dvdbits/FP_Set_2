using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,x,sum = 0 ;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    x = invers(x);
                    sum += x;
                }

                Console.Write("Suma inverselor : " + sum);

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numar!");
            }

            Console.ReadKey();
        }

        private static int invers(int x)
        {
            int t = 0;

            while(x != 0)
            {
                t = t * 10 + x % 10;
                x /= 10;
            }
                
            return t;
        }

    }
}
