using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача: сделать реверс массива. Не используя Reverse.

            Console.Write("Please, enter array lenght: ");
            int N = Convert.ToInt32(Console.ReadLine());     //вводим размер массива

            Console.WriteLine("Please, enter elements of array: ");
            int[] arr1 = new int[N];
            for (int i=0; i < arr1.Length; i++)
                arr1[i] = Convert.ToInt32(Console.ReadLine());     //вводим элементы массива

            Console.WriteLine("Your array is: ");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write("{0} ", arr1[i]);
            Console.ReadLine();

            /*//Reverse Method 1. Simple

            int[] arr2 = arr1;
            Array.Reverse(arr2);
            Console.WriteLine("Reverse Method 1. Your array is: ");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write("{0} ", arr2[i]);
            Console.ReadLine();

            //Reverse Method 2.*/

            for (int i = 0, j = arr1.Length-1; i < j; i++, j--)
            {
                int temp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = temp;
            }

            Console.WriteLine("Reverse Method 2. Your array is: ");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write("{0} ", arr1[i]);
            Console.ReadLine();



        }
    }
}
