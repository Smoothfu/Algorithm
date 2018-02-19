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
