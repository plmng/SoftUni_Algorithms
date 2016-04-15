namespace HW_Problem5_PermutationsWithRepetitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermutationsWithRepetitions
    {
        private int maxNumber;
        private int[] numbers;
        private int[] permutation;
        private int countOfPermutations;
        private int uniqueElementsCount;
        public PermutationsWithRepetitions(int[] arr)
        {
            this.numbers = arr;
            Array.Sort(this.numbers);
            this.uniqueElementsCount = this.GetUniqueElements();
        }

        public void Generate() 
        {
            this.Permute();
            Console.WriteLine("Total permutations: " + this.countOfPermutations);
        }

        private void Permute(int position = 0) 
        {
            
            if (position >= this.numbers.Length-1)
	        {
		        this.PrintPermutation();
                this.countOfPermutations++;
	        }
            else
            {
                for (int numIndex = position; numIndex < this.numbers.Length; numIndex++)
			    {
                    if (this.CheckDifference(numIndex))
	                {
                        this.Swap(position, numIndex);
                        this.Permute(position + 1);
                        this.Swap(position, numIndex); 
	                }
			    }
            }            
        }

        private bool CheckDifference (int index)
        {
            if (index == 0)
	        {
		        return true;
	        }
            return this.numbers[index] != this.numbers[index - 1];
        }
        private void Swap(int from, int to) 
        {
            if (this.numbers[from] == this.numbers[to])
            {
                return;
            }
            int temp = this.numbers[to];
            this.numbers[to] = this.numbers[from];
            this.numbers[from] = temp;
        }

        private void PrintPermutation() 
        {
            Console.WriteLine(string.Join(", ", this.numbers));
        }

        private int GetUniqueElements() 
        {
            int unique = 1 ;
            for (int i = 1; i < this.numbers.Length; i++)
            {
                if (this.numbers[i-1] != this.numbers[i])
                {
                    unique++;
                }
            }
            return unique;
        }
    }
}
