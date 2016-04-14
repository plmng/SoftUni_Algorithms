namespace HW_Problem1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var reversedArray = new ReverseArray(arr);
            reversedArray.PrintRevirsed();
        }
    }
}
 