namespace HW_Problem2_NestedLoopsToRecursion
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
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            var generator = new Generator(n);
            generator.GenerateCombinations();
        }
    }
}
