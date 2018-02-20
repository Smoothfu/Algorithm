using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp114
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 32, 49, 43,34,3454,4362345,34534,78934,45345,3242134,2342379,4134};
            SelectionSort(arr);
            Console.ReadLine();
        }

        static void BubbleSort(int[] arr)
        {
            if(arr==null || !arr.Any())
            {
                return;
            }

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
        }

        static void SelectionSort(int [] arr)
        {
            if(arr==null ||!arr.Any())
            {
                return;
            }

             
            for(int i=0;i<arr.Length-1;i++)
            {
                int minIndex = i;
                for (int j=i+1;j<arr.Length;j++)
                {
                   if(arr[minIndex]>arr[j])
                    {
                        minIndex = j;
                    }
                }

                if(minIndex!=i)
                {
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp;
                }
            }

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
        }

        private static void SwapTwoNumbers(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
