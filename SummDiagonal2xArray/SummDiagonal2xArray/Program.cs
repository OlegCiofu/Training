using System;

namespace SummDiagonal2xArray
{
    class Program
    {
        /* Variant 1. Long
         static void Main(string[] args)
         {
             Methods method = new Methods();

             int[,] arr = method.InputArray();
             method.ShowArray(arr, "Yours");

             int[] mainDiag = method.MainDiag(arr);
             method.ShowArray(mainDiag, "Main Diagonal");
             Console.WriteLine("The summ of Main Diagonal is: {0}", method.SummDiag(mainDiag));
             Console.ReadLine();

             int[] slaveDiag = method.SlaveDiag(arr);
             method.ShowArray(slaveDiag, "Slave Diagonal");
             Console.WriteLine("The summ of Slave Diagonal is: {0}", method.SummDiag(slaveDiag));
             Console.ReadLine();
         }
     }

     public class Methods
     {
         public int[,] InputArray()
         {
             Console.WriteLine("Please, enter range of dual Array: ");
             int n = Int32.Parse(Console.ReadLine());

             int[,] arr = new int[n, n];
             Console.WriteLine("Please, enter elements of array: ");
             for (int i = 0; i < n; i++)
                 for (int j = 0; j <n; j++)
                     arr[i, j] = Convert.ToInt32(Console.ReadLine());
             return arr;
         }

         public void ShowArray(int[,] arr, string flag)
         {
             Console.WriteLine("This is your {0} dual Array: ", flag);
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(0); j++)
                     Console.Write("{0}\t", arr[i, j]);
                 Console.WriteLine();
             }
             Console.ReadLine();
         }

         public void ShowArray(int[] arr, string flag)
         {
             Console.WriteLine("This is your {0} Array: ", flag);
             for (int i = 0; i < arr.Length; i++)
                 Console.Write("{0} ", arr[i]);
             Console.ReadLine();
         }

         public int[] MainDiag (int[,] calculatedArray)
         {
             int[] mainDiag = new int[calculatedArray.GetLength(0)];
             for (int i = 0; i < calculatedArray.GetLength(0); i++)
                 for (int j = 0; j < calculatedArray.GetLength(1); j++)
                     if (i == j)
                         mainDiag[i] = calculatedArray[i, j];
             return mainDiag;
         }

         public int SummDiag (int[] diag)
         {
             int main = 0;
             for (int i = 0; i < diag.Length; i++)
                 main += diag[i];
             return main;
         }

         public int[] SlaveDiag (int[,] calculatedArray)
         {
             int[] slaveDiag = new int[calculatedArray.GetLength(0)];
             for (int i = 0; i < calculatedArray.GetLength(0); i++)
                 for (int j = 0; j < calculatedArray.GetLength(1); j++)
                     if (i + j== calculatedArray.GetLength(0)-1)
                         slaveDiag[i] = calculatedArray[i, j];
             return slaveDiag;
         }
         Variant 2. Short*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter range of dual Array: ");
            int n = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            Console.WriteLine("Please, enter elements of array: ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("This is your dual Array: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();

            int summ1 = 0;
            int summ2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (i == j)
                        summ1 += arr[i, j];
                    else if (i + j == arr.GetLength(0) - 1)
                        summ2 += arr[i, j];
            Console.Write("The summ of Main Diagonal is: {0}", summ1);
            Console.WriteLine();
            Console.Write("The summ of Slave Diagonal is: {0}", summ2);
            Console.ReadLine();


        }


    }
}
