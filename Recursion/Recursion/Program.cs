using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            try1:
            Console.Write("Please, enter digit to calculate factorial: ");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}! = {1}", x, factorial(x));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid number. Please try again");
                Console.ReadLine();
                goto try1;
            }
            goto try1;
        }

        static int factorial(int x)
        {
            int result;

            if (x == 1)
                return x;

            result = x * factorial(x - 1);
            return result;
        }
    }
}