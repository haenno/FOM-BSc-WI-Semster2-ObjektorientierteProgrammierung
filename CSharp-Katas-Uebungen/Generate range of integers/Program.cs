using System;
using System.Collections.Generic;

namespace Generate_range_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GenerateRange(2, 10, 2));
        }
    }
}


public class Kata
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        List<int> TmpList = new List<int>();
        TmpList.Add(min);
        bool Rechnen = true;
        int Zeiger = 1;

        do
        {
            TmpList.Add(min + (step * Zeiger));
            if (max < TmpList[Zeiger])
            {
                TmpList.RemoveAt(Zeiger);
                Rechnen = false;
            }
            Zeiger++;
        } while (Rechnen);

        return TmpList.ToArray();
    }
}
