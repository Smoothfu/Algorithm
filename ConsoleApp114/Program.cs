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
            int[] arr = { 10, 32, 334, 43, 4, 238, 39, 4309, 4348923, 242334, 347, 6756, -3434, 42342, 324893, 434352, 2543439 };
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
