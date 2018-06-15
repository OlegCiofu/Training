using System;
using System.Linq;

namespace ConcatArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача:  сделать объединение 2х чаровых массивов в один. Причем не используя конкат.
            Console.WriteLine("Please, enter range of first array: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            char[] arr1 = new char[n1];
            Console.WriteLine("please, enter chars of first array: ");
            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("This is your first array:");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write("'{0}' ", arr1[i]);
            Console.ReadLine();

            Console.WriteLine("Please, enter range of second array: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            char[] arr2 = new char[n2];
            Console.WriteLine("please, enter chars of second array: ");
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("This is your second array:");
            for (int i = 0; i < arr2.Length; i++)
                Console.Write("'{0}' ", arr2[i]);
            Console.ReadLine();

            //Method 1. Simple. Using LINQ
            char[] arr3 = arr1.Concat(arr2).ToArray();
            Console.WriteLine("Method 1. This is your concated array:");
            for (int i = 0; i < arr3.Length; i++)
                Console.Write("'{0}' ", arr3[i]);
            Console.ReadLine();

            //Method 2.
            char[] arr4 = new char[arr1.Length + arr2.Length];
            for (int i=0; i < arr4.Length; i++)
            {
                if (i < arr1.Length)
                    arr4[i] = arr1[i];
                else
                    arr4[i] = arr2[i - arr1.Length];
            }

            Console.WriteLine("Method 2. This is your concated array:");
            for (int i = 0; i < arr4.Length; i++)
                Console.Write("'{0}' ", arr4[i]);
            Console.ReadLine();

        }
    }
}
