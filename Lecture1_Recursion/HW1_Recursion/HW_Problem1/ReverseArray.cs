namespace HW_Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseArray
    {
        private int[] arr;
        private int swapsCount;
        
        public ReverseArray(int[] arr)
        {
            this.arr = arr;
            this.swapsCount = this.arr.Length / 2;
        }

        public void PrintReversed() 
        {
            this.Reverse();
            this.Print();
        }

        private void Reverse(int index = 0) 
        {
            if (index > this.swapsCount)
            {
                return;
            }
            int swapIndex = this.arr.Length - 1 - index;
            int temp = this.arr[index];
            this.arr[index] = this.arr[swapIndex];
            this.arr[swapIndex] = temp;
            this.Reverse(index + 1);
        }

        private void Print() 
        {
            Console.WriteLine(string.Join(", ", this.arr));
        }
    }
}
