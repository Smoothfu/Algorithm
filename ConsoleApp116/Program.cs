using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp116
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -23, 3, 43, 47, 4389, 4389, 434, 4348, 890, 4899, 434798, 4379823, -43489, 898879, 789087798, 437892324, 46382734, 67889893 };
            BubbleSort(arr);
            SelectionSort(arr);
            Console.ReadLine();
        }

        static void BubbleSort(int [] arr)
        {
            if(arr==null ||!arr.Any())
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

            Console.WriteLine("Bubble Sort:");
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n\n"); 
        }

        static void SelectionSort(int [] arr)
        {
            if(arr==null ||!arr.Any())
            {
                return;
            }

            //Advance the position throught the entire array
            for(int i=0;i<arr.Length;i++)
            {
                //find the min element in the unsorted a[i,...,n-1]
                //assume the min is the first element
                int minIndex = i;

                //test against elements after i to find the smallest.
                for(int j=i+1;j<arr.Length;j++)
                {
                    //If his element is less,then it is the new minimum
                    if(arr[j]<arr[minIndex])
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

            Console.WriteLine("The SelectionSort is :");
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
