using System;

namespace PE005
{
    class Program
    {
        static void Main(string[] args)
        {
            FindNumber f = new FindNumber();
            f.Find();

            Console.Read();
        }
    }

    class FindNumber
    {
        public void Find()
        {
            bool found = false;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int i = 1;

            while(found == false)
            {
                bool flag = true;
                int arrayIndex = 0;

                while(flag == true)
                {
                    if (!(i % numbers[arrayIndex] == 0))
                    {
                        Console.WriteLine("{0} is bad :(", i);

                        

                        flag = false;
                    }
                        
                    if (arrayIndex == 19 && flag == true)
                    {
                        Console.WriteLine("{0} is the magic number!", i);
                        found = true;
                    }



                    arrayIndex++;
                }

                i++;
            }

        }
    }
}
