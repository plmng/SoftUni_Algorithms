using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_Problem1_RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]
            {
                1, 2, 3
            };

            Console.WriteLine(FindSum(0, arr));


        }

        private static int FindSum(int index, int[] arr) 
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + FindSum(index+1, arr);
            
        }
    }
}
