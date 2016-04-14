namespace HW_Problem1_PermutationsWithoutRepetitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermutationsWithoutRepetitions
    {
        private int maxNumber;
        private int[] numbers;
        private int countOfPermutations;
        public PermutationsWithoutRepetitions(int n)
        {
            this.maxNumber = n;
            this.numbers = Enumerable.Range(1, this.maxNumber).ToArray();
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
            int temp = this.numbers[to];
            this.numbers[to] = this.numbers[from];
            this.numbers[from] = temp;
        }

        private void PrintPermutation() 
        {
            Console.WriteLine(string.Join(", ", this.numbers));
        }
    }
}
