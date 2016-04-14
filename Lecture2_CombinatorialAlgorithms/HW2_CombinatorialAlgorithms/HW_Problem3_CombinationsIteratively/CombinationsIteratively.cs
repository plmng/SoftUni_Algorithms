namespace HW_Problem3_CombinationsIteratively
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CombinationsIteratively
    {
        private int numbers;
        private int groups;
        private int[] combination;
        private int combinationsCount;

        public CombinationsIteratively(int n, int k)
        {
            this.numbers = n;
            this.groups = k;
            this.combination = Enumerable.Range(1, this.groups).ToArray();
        }

        public void Generate()
        {
            this.Print();
            while (this.CalcNextCombination())
            {
                this.Print();
            }

            Console.WriteLine("Total combinations: " + this.combinationsCount);
        }

        private bool CalcNextCombination()
        {
            int index = this.groups - 1;
            this.combination[index]++;
            while ((index > 0) && (this.combination[index] >= this.numbers - this.groups + 2 + index))
            {
                index--;
                this.combination[index]++;
            }

            if (this.combination[0] > this.numbers + 1 - this.groups)
            {
                return false;
            }

            for (int i = index + 1; i < this.groups; i++)
            {
                combination[i] = combination[i - 1] + 1;
            }
                
            return true;
        }

        private void Print()
        {
            Console.WriteLine(string.Join(", ", this.combination));
            this.combinationsCount++;
        }
    }
}
