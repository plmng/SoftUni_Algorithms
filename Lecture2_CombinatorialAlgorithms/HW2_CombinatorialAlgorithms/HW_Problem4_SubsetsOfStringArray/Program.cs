namespace HW_Problem4_SubsetsOfStringArray
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
            string[] set = new string[] { "test", "rock", "fun" };
            int k = 2;

            var combinations = new CombinationsWithOutRepetitions(set, k);
            combinations.Generate();

        }
    }
}
