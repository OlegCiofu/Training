using System;

namespace ConcatAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();
            int[] arr1 = method.EnterArray("First");
            method.ShowArr(arr1, "First");

            int[] arr2 = method.EnterArray("Second");
            method.ShowArr(arr2, "Second");

            int[] arr3 = method.Concat(arr1, arr2);
            method.ShowArr(arr3, "Concatenated");

            //int[] arr4 = method.Sort(arr3);
           // method.ShowArr(arr4, "Sorted");

            int[] arr5 = method.SortBest(arr3);
            method.ShowArr(arr5, "Sorted Best");
        }
    }

    class Methods
    {
        public int[] EnterArray(string counter)
        {
            Console.WriteLine("Please, enter range of {0} array: ", counter);
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please, enter elements of {0} array: ", counter);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Int32.Parse(Console.ReadLine());
            return arr;
        }
        public void ShowArr(int[] arr, string counter)
        {
            Console.WriteLine("Your {0} array  is: ", counter);
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);
            Console.ReadLine();
        }

        public int[] Concat (int[] input1, int[] input2)
        {
            int[] arr = new int[input1.Length + input2.Length];
            for (int i=0; i<arr.Length; i++)
            {
                if (i < input1.Length)
                    arr[i] = input1[i];
                else
                    arr[i] = input2[i - input1.Length];
            }
            return arr;
        }

        public int[] Sort (int[] input)
        {
            int[] arr = input;
            int poz = 0;
            int min = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for(int j=i; j<arr.Length;j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        poz = j;
                    }
                }
                int temp = arr[i];
                arr[i] = min;
                arr[poz] = temp;
            }
            return arr;

        }

        public int[] SortBest(int[] input)
        {
            int temp;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                   // Console.WriteLine($"Cycle {i+j}. i={i}, j={j}, input[i]={input[i]}, input[j]={input[j]}");
                    if (input[i] > input[j])
                    {
                        //Console.WriteLine("Conditions is true, making changes and next circle");
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                    //else
                        //Console.WriteLine("Conditions is false, going to next circle");
                    //Console.ReadLine();
                }
            }
            return input;

        }
    }


}
