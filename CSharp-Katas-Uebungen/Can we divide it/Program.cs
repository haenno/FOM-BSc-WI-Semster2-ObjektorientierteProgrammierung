using System;

namespace Can_we_divide_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.is_divide_by(-12, 2, 6));
        }
    }
}


public class Kata
{
    public static bool is_divide_by(int number, int a, int b)
    {
        if (number % a == 0 && number % b == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
