using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE002
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
            int x = 1;
            int y = 2;

            int sum = 0;

            while(y < 4000000)
            {
                if (y % 2 == 0)
                    sum += y;

                int z = x + y;
                x = y;
                y = z;
            }

            Console.WriteLine(sum);
        }
    }
}
