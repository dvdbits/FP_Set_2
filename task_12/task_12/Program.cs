using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, tSecv = 0, nSecv = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    
                    if(x != 0)
                    {
                        tSecv++;
                    }
                    else
                    {
                        if(tSecv != 0)
                        {
                            nSecv++;
                        }
                        tSecv = 0;
                    }

                }

                Console.WriteLine("Numar secvente : " + nSecv);
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numar!");
            }

            Console.ReadKey();
        }
    }
}
