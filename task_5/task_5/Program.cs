using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            decimal  x, res = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Introduceti secventa de numere : ");
                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    if (x == i)
                    {
                        res++;
                    }
                }
                Console.WriteLine("Exista " + res + " numere egale cu pozitia pe care apar in secventa");
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere!");
            }
            Console.ReadKey();
        }
    }
}
