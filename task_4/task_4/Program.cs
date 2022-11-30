using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            decimal a, x , p = -1;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduceti numarul de cautat : ");
                a = Convert.ToDecimal(Console.ReadLine());    
            

                Console.WriteLine("Introduceti secventa de numere : ");
                for(int i = 0; i < n; ++i)
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    if(p == -1 && x == a)
                    {
                        p = i;
                    }

                }

                Console.WriteLine("Pozitia numarului " + a + " in sir este : " + p);
            }
            catch(Exception error)
            {
                Console.WriteLine("Va rog introduceti numere!");
            }
            Console.ReadKey();
        }
    }
}
