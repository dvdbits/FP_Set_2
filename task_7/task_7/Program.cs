using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            decimal x, maxNumber = 0, minNumber = 0;

            try
            {
                Console.WriteLine("Introduceti numarul n : ");
                n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Introduceti secventa de numere : ");
                for (int i = 0; i < n; ++i)
                {
                    x = Convert.ToDecimal(Console.ReadLine());

                    if(i == 0)
                    {
                        maxNumber = x;
                        minNumber = x;
                    }

                    if(x > maxNumber)
                    {
                        maxNumber = x;
                    }

                    if(x < minNumber)
                    {
                        minNumber = x;
                    }
                }

                Console.WriteLine("Cel mai mare numar al secventei : " + maxNumber);
                Console.WriteLine("Cel mai mic numar al secventei : " + minNumber);

            }
            catch (Exception error)
            {
                Console.WriteLine("Va rog introduceti numere!");
            }

            Console.ReadKey();
        }
    }
}
