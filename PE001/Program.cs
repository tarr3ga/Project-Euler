using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE001
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
        int sum;

        public void GetSum()
        {
            for(int i = 3; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine("The total is:  {0}", sum);
        }
    }
}
