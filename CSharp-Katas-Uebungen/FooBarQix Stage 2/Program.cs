using System;

namespace FooBarQix_Stage_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kata http://codingdojo.org/kata/FizzBuzz/   Stage II

            for (int i = 1; i <= 100; i++)
            {
                bool mit3 = (Convert.ToString(i)).Contains("3");
                bool mit5 = Convert.ToString(i).Contains("5");
                
                if ((i % 3 == 0) || (mit3))
                {
                    Console.Write("Fizz");
                }

                if ((i % 5 == 0)|| mit5 )
                {
                    Console.Write("Buzz");
                }

                if ((i % 5 != 0) && (i % 3 != 0) && !mit3 && !mit5)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }
        }
    }
}
