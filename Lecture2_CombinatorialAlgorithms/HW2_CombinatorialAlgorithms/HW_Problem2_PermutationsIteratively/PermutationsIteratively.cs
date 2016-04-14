namespace HW_Problem2_PermutationsIteratively
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermutationsIteratively
    {
        private int maxNumber;
        private int[] numbers;
        private int[] helper;
        private int countOfPermutations;

        public PermutationsIteratively(int n)
        {
            this.maxNumber = n;
            this.numbers = Enumerable.Range(1, this.maxNumber).ToArray();
            this.helper = Enumerable.Range(0, this.maxNumber + 1).ToArray();
        }

        public void Generate(int startIndex = 0) 
        {
            this.PrintPermutation();
            int index = 1;
            while (index < this.maxNumber)
            {
                this.helper[index]--;
                int secondIndex = 0;

                if (index % 2 != 0)
                {
                    secondIndex = this.helper[index];
                }
                else 
                {
                    secondIndex = 0;
                }
                this.Swap(secondIndex, index);

               
                index = 1;

                while (this.helper[index] == 0)
                {
                    this.helper[index] = index;
                    index++;
                }

                this.PrintPermutation();
            }
            
            Console.WriteLine("Total permutations: " + this.countOfPermutations);
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
            this.countOfPermutations++;
        }
    }
}
