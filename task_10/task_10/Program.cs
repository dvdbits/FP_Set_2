using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tLength = 1, maxLength = 0;
            double a, b;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                a = Convert.ToDouble(Console.ReadLine());
                
                for (int i = 1; i < n; ++i)
                {
                    b = Convert.ToDouble(Console.ReadLine());

                    if(a == b)
                    {
                        tLength++;
                    }
                    else
                    {
                        tLength = 1;
                    }

                    maxLength = Math.Max(maxLength, tLength);

                    b = a;
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numar!");

            }
            Console.WriteLine("Numarul maxim de numere consecutive egale din secventa : " + maxLength);
            Console.ReadKey();
        }
    }
}
