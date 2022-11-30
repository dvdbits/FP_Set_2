using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, negative = 0 , pozitive = 0, zero = 0;

            try
            {

                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti sirul de numere : ");
                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToInt32(Console.ReadLine());

                    if(x == 0)
                    {
                        zero++;
                    }
                    else if (x > 0)
                    {
                        pozitive++;
                    }
                    else
                    {
                        negative++;
                    }
                    
                }

                Console.WriteLine("In sir exista : " + negative + " numere negative, " + zero + " numere egale cu 0, " + pozitive + " numere pozitive");
            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog sa introduceti numere intregi!");
            }

            Console.ReadKey();
        }
    }
}
