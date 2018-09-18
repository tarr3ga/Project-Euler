using System;
using System.Collections.Generic;

namespace PE007
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPrimeNumbers f = new FindPrimeNumbers();
            f.Find();

            Console.Read();
        }
    }

    class FindPrimeNumbers
    {
        List<long> primes = new List<long>();

        long number = 5;

        public void Find()
        {
            int count = 3;

            while (true)
            {
                number++;

                bool prime = true;
                long flag = number % 10;

                if(flag == 1 || flag == 3 || flag == 7 || flag == 9)
                {
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                            prime = false;
                    }
                } else
                {
                    prime = false;
                }


                if (prime == true)
                    count++;

                Console.WriteLine(number);

                if(count == 10001)
                {
                    Console.WriteLine("The 10,001st prme number is: {0}", number);
                    break;
                }
                    
            }
        }
    }
}
