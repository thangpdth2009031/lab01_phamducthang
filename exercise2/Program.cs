using System;

namespace exercise2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 +" is the largest number.");
            } else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 +" is the largest number.");
            }
            else
            {
                Console.WriteLine(num3 +" is the largest number.");
            }
        }
    }
}