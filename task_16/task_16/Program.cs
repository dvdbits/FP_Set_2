using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, first, a, b = 0, x = 0, k = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                a = Convert.ToInt32(Console.ReadLine());

                first = a;

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

                if (first < b)
                {
                    if (x != -1)
                    {
                        k++;
                        x = -1;
                    }
                }

                if(first > b)
                {
                    if (x != 1)
                    {
                        k++;
                        x = 1;
                    }
                }

                if (k == 2 || k == 3)
                {
                    Console.WriteLine("Secventa este bitonica rotita");
                }
                else
                {
                    Console.WriteLine("Secventa nu este bitonica rotita");
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
