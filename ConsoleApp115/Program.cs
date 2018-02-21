using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp115
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] arr = new int[20];
            for(int i=0;i<20;i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }

            Console.WriteLine("The original array:");

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n\nAfter the Insertion Sort:");
            InsertionSort(arr);
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

        static void SelectionSort(int[] arr)
        {
            if (arr == null || !arr.Any())
            {
                return;
            }

            for(int i=0;i<arr.Length;i++)
            {
                int minIndex = i;
                for(int j=i+1;j<arr.Length;j++)
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

        static void InsertionSort(int [] arr)
        {
            if(arr==null || !arr.Any())
            {
                return;
            }

            for(int i=1;i<arr.Length;i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while(j>=0 && temp<arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }    
}
