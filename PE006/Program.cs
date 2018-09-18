using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE006
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.GetSum();

            Console.Read();
        }
    }

    class Calculate
    {
        public void GetSum()
        {
            long sum = 0;

            for(long i = 1; i <= 100; i++)
            {
                sum += (i * i);
            }

            Console.WriteLine(sum);

            long sum2 = 0;

            for(long i = 1; i <= 100; i++)
            {
                sum2 += i;
            }

            sum2 = sum2 * sum2;

            Console.WriteLine(sum2);

            long final = sum2 - sum;

            Console.WriteLine(final);
        }
    }
}
