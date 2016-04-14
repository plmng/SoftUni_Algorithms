namespace HW_Problem2_PermutationsIteratively
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

            var permutations = new PermutationsIteratively(n);
            permutations.Generate();
        }
    }
}
