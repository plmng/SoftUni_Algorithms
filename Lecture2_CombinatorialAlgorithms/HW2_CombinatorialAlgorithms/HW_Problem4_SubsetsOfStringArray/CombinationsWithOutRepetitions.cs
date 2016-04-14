namespace HW_Problem4_SubsetsOfStringArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CombinationsWithOutRepetitions
    {
        private int numbers;
        private int size;
        private int[] combination;
        private string[] elements;
        private string[] stringcombinations;

        public CombinationsWithOutRepetitions(string[] arr, int k)
        {
            this.elements = arr;
            this.numbers = this.elements.Length;
            this.size = k;
            this.combination = new int[this.size];
            this.stringcombinations = new string[this.size];
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
            for (int i = 0; i < this.combination.Length; i++)
            {
                int index = this.combination[i]-1;
                this.stringcombinations[i] = this.elements[index];
            }
            Console.WriteLine(string.Join(", ", this.stringcombinations));
        }
    }
}
