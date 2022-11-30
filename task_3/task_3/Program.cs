using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            try
            {
                n = Convert.ToInt32(Console.ReadLine());

                if(n < 1)
                {
                    throw new Exception("");
                }

                int p = 1;
                for(int i = 2; i <= n; i++)
                {
                    p *= i;
                }

                Console.WriteLine("Suma numerelor de la 1 la n : " + n * (n + 1) / 2);
                Console.WriteLine("Produsul numerelor de la 1 la n : " + p);
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti un numar intreg mai mare sau egal cu 1");
            }

            Console.ReadKey();

        }
    }
}
