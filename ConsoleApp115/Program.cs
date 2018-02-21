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

            int[] arr = new int[10];
            for(int i=0;i<10;i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }

            Console.WriteLine("The original array:");

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n\nAfter Bubble sort:");
            BubbleSort(arr);
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
    }
}
