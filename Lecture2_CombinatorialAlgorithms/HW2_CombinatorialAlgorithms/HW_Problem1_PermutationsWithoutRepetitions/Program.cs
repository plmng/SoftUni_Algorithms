namespace HW_Problem1_PermutationsWithoutRepetitions
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
            
            var permutationsWithoutRepetitions = new PermutationsWithoutRepetitions(n);
            permutationsWithoutRepetitions.Generate();
        }
    }
}
