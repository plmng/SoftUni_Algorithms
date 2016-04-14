using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_Problem1_VariationWithRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            
            Console.WriteLine();

            Console.WriteLine("Variations With Repetitions:" );
            Console.WriteLine(new string('-', 30));
            var variationsWithRepets = new VariationsWithRepetitions(n, k);
            variationsWithRepets.Generate();
            
            
            Console.WriteLine();
            
            Console.WriteLine("Variations Without Repetitions:");
            Console.WriteLine(new string('-', 30));
            var variationsWithOUTRepets = new VariationsWithoutRepetitions(n, k);
            variationsWithOUTRepets.Generate();

            
            Console.WriteLine();

            
            Console.WriteLine("Combinations With Repetitions:");
            Console.WriteLine(new string('-', 30));
            var combinationsWithRepets = new CombinationsWithRepetitions(n, k);
            combinationsWithRepets.Generate();

            
            Console.WriteLine();

            Console.WriteLine("Combinations Without Repetitions:");
            Console.WriteLine(new string('-', 30));
            var combinationsWithOUTRepets = new CombinationsWithoutRepetitions(n, k);
            combinationsWithOUTRepets.Generate();
        }
    }
}
