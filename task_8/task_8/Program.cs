using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            int a = 0,b = 1;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                if(n < 1)
                {
                    throw new Exception("");
                }

                if(n == 1)
                {
                    Console.WriteLine(a);
                    Console.ReadKey();
                    return;
                }

                if (n == 2)
                {
                    Console.WriteLine(a);
                    Console.ReadKey();
                    return;
                }


                for (int i = 3; i <= n; ++i)
                {
                     int c = a + b;
                     a = b;
                     b = c;
                }

                Console.WriteLine("Al " + n + "-lea element al sirului Fibonacci este " + b);

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numar intreg pozitiv!");
            }

            Console.ReadKey();
        }
    }
}
