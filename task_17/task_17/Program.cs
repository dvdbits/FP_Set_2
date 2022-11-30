using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, k = 0, maxIncubare = -1;
            bool corect = true;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    while(x != 0 && x != 1)
                    {
                        Console.WriteLine("Introduceti 0 sau 1 ");
                        x = Convert.ToInt32(Console.ReadLine());
                    }

                    if(x == 0)
                    {
                        k++;
                    }

                    if(x == 1)
                    {
                        k--;
                    }

                    maxIncubare = Math.Max(maxIncubare, k);

                    if(k < 0)
                    {
                        corect = false;
                    }

                }

                if(k != 0)
                {
                    corect = false;
                }

                if (corect)
                {
                    Console.WriteLine("Secventa de paranteze e corecta si are nivelul maxim de incubare " + maxIncubare);
                }
                else
                {
                    Console.WriteLine("Secventa de paranteze nu e corecta");
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
