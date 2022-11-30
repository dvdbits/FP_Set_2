using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, x = 0, k = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                a = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < n; ++i)
                {
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a < b)
                    {
                        if (x != 1)
                        {
                            k++;
                            x = 1;
                        }
                    }

                    if (a > b)
                    {
                        if (x != -1)
                        {
                            k++;
                            x = -1;
                        }
                    }

                    a = b;
                }

                if (k == 2 && x == -1)
                {
                    Console.WriteLine("Secventa este bitonica");
                }
                else
                {
                    Console.WriteLine("Secventa nu este bitonica");
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
