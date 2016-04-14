namespace Exrc_Problem1_VariationWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VariationsWithoutRepetitions
    {
        private int numbers;
        private int size;
        private int[] variation;
        private bool[] used;
 
        public VariationsWithoutRepetitions (int n, int k)
	    {
            this.numbers = n;
            this.size = k;
            this.variation = new int[this.size];
            this.used = new bool[this.numbers + 1];
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
                    if (!this.used[number])
                    {
                        this.used[number] = true;
                        this.variation[index] = number;
                        this.Generate(index + 1);
                        this.used[number] = false;
                    }
                    
                }
            }
               
               
        }
        private void PrintVariation()
        {
            Console.WriteLine(string.Join(", ", this.variation));
        }

    }
}
