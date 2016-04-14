namespace Exrc_Problem1_VariationWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class CombinationsWithoutRepetitions
    {
        private int numbers;
        private int size;
        private int[] combination;
 
        public CombinationsWithoutRepetitions(int n, int k)
	    {
            this.numbers = n;
            this.size = k;
            this.combination = new int[this.size];
	    }

        public void Generate()
        {
            this.GenerateCombinations(1, 0);
        }
       
        private void GenerateCombinations(int startNumber, int index = 0) 
        {
            if (index >= this.size)
            {
                this.PrintCombination();
            }
            else
            {
                for (int number = startNumber; number <= this.numbers; number++)
                {
                    this.combination[index] = number;
                    this.GenerateCombinations(number + 1, index + 1);
                }
            }
               
        }
        
        private void PrintCombination()
        {
            Console.WriteLine(string.Join(", ", this.combination));
        }
    }
}
