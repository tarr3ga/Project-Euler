using System;

namespace PE010
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPythagoreanTriplet f = new FindPythagoreanTriplet();
            f.Find();

            Console.Read();
        }
    }

    class FindPythagoreanTriplet
    {
        int a, b, c;

        bool found = false;

        public void Find()
        {
            a = 1;
            b = 3;
            c = 3;

            Search();

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);
            Console.WriteLine("The product of the three is: {0}", a * b * c);
        }
        private void Search()
        {
            while (found == false) {
                double left = Math.Pow(a, 2);
                double right = Math.Pow(b, 2);
                double result = Math.Pow(c, 2);

                if (left + right + result == result && left + right == Math.Pow(c, 2))
                {
                    found = true;
                }

                if (b >= 33 || c >= 33)
                {
                    a++;
                    b = a + 1;
                } else
                {
                    b++;
                }

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(left);
                Console.WriteLine(right);
                Console.WriteLine(result);
                Console.WriteLine(found);

                //Console.Read();
            }
        }
    }
}
