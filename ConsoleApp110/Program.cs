using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp110
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 10, 89, 3, 32, 332489, 4322, 893, 323, 4289, 23312, 42990, 32332, 289023, 428390, 4237890, 89359, 4324, 8978798, 0, 4373498, 342332, 43782934 };
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
            if(arr==null || !arr.Any())
            {
                return;
            }

            //advance the position through the entire array,
            for(int i=0;i<arr.Length-1;i++)
            {
                //find the min element in the unsorted a[i..n-1]
                //assume the min is the first element.
                int minIndex = i;

                //test agaginst elements after i to find the smallest
                for(int j=i+1;j<arr.Length-1;j++)
                {
                    //if this element is less,then it is the new minimum
                    if(arr[j]<arr[minIndex])
                    {
                        //found new minimum,remember its index
                        minIndex = j;
                    }
                }

                if(minIndex!=i)
                {
                    Swap(ref arr[i], ref arr[minIndex]);
                }
            }

            foreach(var a in arr)
            {
                Console.WriteLine(a);
            }
        }

        private static void Swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
