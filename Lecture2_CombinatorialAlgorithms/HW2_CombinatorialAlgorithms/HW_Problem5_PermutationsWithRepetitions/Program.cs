using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Problem5_PermutationsWithRepetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = new int[] { 1, 3, 5, 5 };
            var permutation = new PermutationsWithRepetitions(set);
            permutation.Generate();

        }
    }
}
