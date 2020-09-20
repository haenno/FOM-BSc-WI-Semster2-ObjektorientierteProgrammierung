using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the staircase function below.
    static void staircase(int n)
    {

    

        for (int i=0; i<n; i++)
        {
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }

    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Staircase: Gib Etagenanzahl ein... ");
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            Console.Write("Taste für Neustart...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
