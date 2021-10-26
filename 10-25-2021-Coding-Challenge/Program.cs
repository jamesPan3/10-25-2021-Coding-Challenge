using System;

namespace _10_25_2021_Coding_Challenge
{
    class Program
    {

        static int GCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            return GCD(y, x % y);
        }

        static void Simplify(string fraction)
        {
            if (fraction.Contains('/') && fraction.IndexOf("/") != 0 && fraction.IndexOf("/") != fraction.Length-1)
            {
                string[] StringNumbers = fraction.Split('/');

                if (StringNumbers.Length > 2)
                {
                    Console.WriteLine("Please only use one '/' within your fraction.\n");
                }
                else
                {
                    int x = 0;
                    int y = 0;

                    for (int i = 0; i < StringNumbers.Length; i++)
                    {
                        if (i == 0)
                        {
                            x = Int32.Parse(StringNumbers[i]);
                        }
                        if (i == 1)
                        {
                            y = Int32.Parse(StringNumbers[i]);
                        }
                    }

                    int divisor;
                    divisor = GCD(x, y);

                    x = x / divisor;
                    y = y / divisor;

                    if (y == 1)
                    {
                        Console.WriteLine(x + "\n");
                    }
                    else
                    {
                        Console.WriteLine(x + "/" + y + "\n");

                    }
                }  
            }
            else
            {
                Console.WriteLine("Please ensure that your fraction, " + fraction + ", is formatted properly. EX: 4/6\n");
            }
        }


        static void Main(string[] args)
        {
            Simplify("4/6");
            Simplify("10/11");
            Simplify("100/400");
            Simplify("8/4");
        }
    }
}
