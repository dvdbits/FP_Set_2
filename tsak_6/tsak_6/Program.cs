using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            decimal x, last = 0;

            bool isAsc = true;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Introduceti secventa de numere : ");
                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToDecimal(Console.ReadLine());

                    if (i > 0)
                    {
                       if(x < last)
                        {
                            isAsc = false;
                        }
                    }

                    last = x;
                }

                if (isAsc)
                {
                    Console.WriteLine("Sirul este crescator!");
                }
                else
                {
                    Console.WriteLine("Sirul nu este crescator!");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere!");
            }
            Console.ReadKey();
        }
    }
}
