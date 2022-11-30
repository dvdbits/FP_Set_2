using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,first,a,b = 0, k = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                first = Convert.ToInt32(Console.ReadLine());

                a = first;
                
                for (int i = 1; i < n; ++i)
                {
                    b = Convert.ToInt32(Console.ReadLine());

                    if(a > b)
                    {
                        ++k;
                    }

                    a = b;
                }

                if(b > first)
                {
                    ++k;
                }


                if(k < 2)
                {
                    Console.WriteLine("Secventa este crescatoare rotita");
                }
                else
                {
                    Console.WriteLine("Secventa nu este crescatoare rotita");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numar!");
            }

            Console.ReadKey();
        }
    }
}
