using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double x, minim, maxim;

            bool minimChanged = false, maximChanged = false;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");

                x = Convert.ToDouble(Console.ReadLine());
                minim = x;
                maxim = x;

                for (int i = 1; i < n; ++i)
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    
                    if(x < minim)
                    {
                        minim = x;
                        minimChanged = true;
                    }
                    
                    if(x > maxim)
                    {
                        maxim = x;
                        maximChanged = true;
                    }
                }

                if(minimChanged && maximChanged)
                {
                    Console.WriteLine("Secventa nu este monotona");
                }
                else
                {
                    Console.WriteLine("Secventa este monotona");
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
