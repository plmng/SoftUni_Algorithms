namespace HW_Problem5_CombinationsWithoutRepetition
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
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            var combinator = new Combinator(n, k);
            combinator.GenerateCombinations();
        }
    }
}
