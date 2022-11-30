using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, first, a, b = 0, asc = 0, desc = 0;

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

                    if(a > b)
                    {
                        asc++;
                    }

                    if(a < b)
                    {
                        desc++;
                    }

                    a = b;
                }


                if (b > first)
                {
                    asc++;
                }

                if (b < first)
                {
                    desc++;
                }

                if (asc < 2 || desc < 2)
                {
                    Console.WriteLine("Secventa este monotona rotita");
                }
                else
                {
                    Console.WriteLine("Secventa nu este monotona rotita");
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
