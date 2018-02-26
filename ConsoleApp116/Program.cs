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
            InsertSort(arr);

            QuickSort(arr,0,arr.Length-1);
            Console.WriteLine("Quick Sort:");
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n\n\n");
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

        static void InsertSort(int[] arr)
        {
            if(arr==null || !arr.Any())
            {
                return;
            }

            for(int i=1;i<arr.Length;i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp<arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }

            Console.WriteLine("Insertion Sort:");
            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n\n\n");
        }

        private static int PartitionSort(int[]arr,int i,int j)
        {
            int pivot = arr[j];
            int small = i - 1;
            for(int k=i;k<j;k++)
            {
                if(arr[k]<=pivot)
                {
                    Swap(ref arr, ref k, ref small);
                }
            }

            int small1 = small + 1;
            Swap(ref arr, ref j, ref small1);
            return small + 1;            
        }

        private static void Swap(ref int[]arr,ref int k,ref int small)
        {
            int temp;
            temp = arr[k];
            arr[k] = arr[small];
            arr[small] = temp;
        }

        private static void QuickSort(int []arr,int i,int j)
        {
            if(i<j)
            {
                int pos = PartitionSort(arr, i, j);
                QuickSort(arr, i, pos - 1);
                QuickSort(arr, pos + 1, j);
            }
        }
    }
}
