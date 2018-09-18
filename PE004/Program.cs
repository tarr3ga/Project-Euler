using System;

namespace PE004
{
    class Program
    {
        static void Main(string[] args)
        {
            FindLargestPrimeFactor f = new FindLargestPrimeFactor();
            f.FindFactor();

            Console.Read();
        }
    }

    class FindLargestPrimeFactor
    {
        const long number = 600851475143;

        public void FindFactor()
        {
            for(long i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);
                }               
            }

            Console.WriteLine("All done...");
        }
    }
}
