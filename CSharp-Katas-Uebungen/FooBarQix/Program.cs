using System;

namespace FooBarQix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kata http://codingdojo.org/kata/FizzBuzz/ 

            for (int i =1; i<=100;i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if ((i%5!=0)&&(i%3!=0))
                {
                    Console.Write(i);
                }
                Console.Write("\n");
                //Gedanke: Kann man auch switch() cases nutzen? Ich kenne das nur als abfrage von strings...
            }
        }
    }
}
