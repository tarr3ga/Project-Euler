using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE003
{
    class Program
    {
        static void Main(string[] args)
        {
            Find f = new Find();

            f.FindNumber();

            Console.Read();
        }
    }

    class Find
    {
        public void FindNumber()
        {
            int final = 0;

            for(int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {
                    int product = i * j;

                    string productToString = product.ToString();

                    if(productToString.Length % 2 == 0)
                    {
                        string left = productToString.Substring(0, productToString.Length / 2);
                        string right = productToString.Substring(productToString.Length / 2, productToString.Length / 2);

                        char[] array = right.ToCharArray();
                        Array.Reverse(array);
                        string rightReversed = new string(array);

                        if(left == rightReversed)
                        {
                            int temp = Convert.ToInt32(productToString);

                            if(temp > final)
                            {
                                final = temp;
                            }

                            Console.WriteLine(final);
                        }
                    }
                }
            }

            Console.WriteLine("The final answer is {0}", final);
        }
    }
}
