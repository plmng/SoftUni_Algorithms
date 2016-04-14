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
        private int countOfPermutations;
        private int uniqueElementsCount;
        public PermutationsWithRepetitions(int[] arr)
        {
            this.numbers = arr;
            Array.Sort(this.numbers);
            this.uniqueElementsCount = this.GetUniqueElements();
        }

        public void Generate(int startIndex = 0) 
        {
            this.Permute();
            Console.WriteLine("Total permutations: " + this.countOfPermutations);
        }

        private void Permute(int startIndex = 0) 
        {
            if (startIndex >= this.numbers.Length - 1)
            {
                this.PrintPermutation();
                this.countOfPermutations++;
            }
            else
            {
                for (int i = startIndex; i < this.numbers.Length; i++)
                {
                    this.Swap(startIndex, i);
                    this.Permute(startIndex + 1);
                    this.Swap(startIndex, i);                  
                }
            }
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
            int unique = 0;
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
