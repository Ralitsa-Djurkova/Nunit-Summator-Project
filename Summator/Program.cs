using System;

namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6 });

            var input = Console.ReadLine();
           
            if(sum == 21)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }

            double average = Summator.Average(new double[] { 5, 10, 15 });

            if(average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}
