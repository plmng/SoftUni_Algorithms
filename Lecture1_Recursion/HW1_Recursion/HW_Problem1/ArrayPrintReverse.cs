namespace HW_Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayPrintReverse
    {
        private int[] arr;

        public ArrayPrintReverse(int[] arr)
        {
            this.arr = arr;
        }
        
        public void PrintRevirsed()
        {
            this.PrintReversed(0);
        }
        
        private void PrintReversed(int index)
        {
            int revercedIndex = this.arr.Length -index - 1;
            if (revercedIndex == 0)
	        {
                Console.WriteLine(arr[revercedIndex]);
                return;
	        }
            Console.Write(arr[revercedIndex] + ", ");
            this.PrintReversed(index + 1);
            
        }

    }
}
