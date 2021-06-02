using System;
using System.IO.IsolatedStorage;
using System.Runtime.InteropServices;

namespace exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (var i = 1; i <= 20; i++)
            {
                Console.WriteLine(String.Format("{0}: ", i));
                for (var x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                    {
                        Console.WriteLine(x);       
                    }
                }
            }
        }
    }
}