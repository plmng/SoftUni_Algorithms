namespace Exrc_Problem1_VariationWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VariationsWithRepetitions
    {
        private int numbers;
        private int size;
        private int[] variation;
 
        public VariationsWithRepetitions (int n, int k)
	    {
            this.numbers = n;
            this.size = k;
            this.variation = new int[this.size];
	    }

        public void Generate(int index = 0)
        {
            if (index >= this.size)
            {
                this.PrintVariation();
            }
            else
            {
                for (int number = 1; number <= this.numbers; number++)
                {
                    this.variation[index] = number;
                    this.Generate(index + 1);
                }
            }
               
               
        }
        private void PrintVariation()
        {
            Console.WriteLine(string.Join(", ", this.variation));
        }

    }
}
