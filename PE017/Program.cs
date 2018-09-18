using System;

namespace PE017
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterCount l = new LetterCount();
            l.Go();

            Console.Read();
        }
    }

    class LetterCount
    {
        string[] setOne = new string[]
        {
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thriteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen"
        };

        string[] setTwo = new string[]
        {
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };

        string[] setThree = new string[]
        {
            "hundred",
            "thousand"
        };

        int count = 0;

        public void Go() {
            foreach(string s in setOne)
            {
                count += s.Length;
            }


            for(int i = 1; i <= 7; i++)
            {
                for(int j = 0; j <= 9; j++)
                {
                    count += setTwo[i].Length;
                    count += setOne[j].Length;
                }
            }

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(j == 0 || j == 1)
                    {
                        if(j == 0)
                        {
                            for(int k = 0; k < 9; k++)
                            {
                                count += setOne[i].Length;
                                count += setThree[0].Length;
                                count += 3; // Three letters for the word "and"
                                count += setOne[k].Length;

                                Console.WriteLine(setOne[i] + " " + setThree[0] + " and " + setOne[k]); 
                            }
                        } else if(j == 1)
                        {
                            for(int k = 0; k < 10; k++)
                            {
                                count += setOne[i].Length;
                                count += setThree[0].Length;
                                count += 3; // Three letters for the word "and"
                                count += setOne[k + 9].Length;

                                Console.WriteLine(setOne[i] + " " + setThree[0] + " and " + setOne[k + 9]);
                            }
                        }
                    } else
                    {
                        for(int k = 0; k < 10; k++)
                        {
                            count += setOne[i].Length;
                            count += setThree[0].Length;
                            count += 3; // Three letters for the word "and"
                            count += setTwo[j - 2].Length;
                            count += setOne[k].Length;

                            Console.WriteLine(setOne[i] + " " + setThree[0] + " and " + setTwo[j - 2] + " " + setOne[k]);
                        }
                    }
                }
            }

            count += setOne[0].Length;
            count += setThree[1].Length;

            Console.WriteLine(count);
        }
    }
}