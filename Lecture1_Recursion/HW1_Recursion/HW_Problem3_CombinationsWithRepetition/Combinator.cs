namespace HW_Problem3_CombinationsWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Combinator
    {
        private int startNumber;
        private int[] vector;
        private int elementstsCount;
        private int maxNumber;

        public Combinator(int n, int k)
        {
            this.maxNumber = n;
            this.elementstsCount = k;
            this.vector = new int[this.elementstsCount];
            this.startNumber = 1;
        }

        public void GenerateCombinations()
        {
            this.Generate(0);
        }

        private void Generate(int index)
        {
            if (index == this.elementstsCount)
	        {
		        this.PrintVector();
	        }
            else 
            {
                for (int number = this.startNumber ; number <= this.maxNumber; number++)
			    {
			        this.vector[index] = number;
                    this.Generate(index+1);
			    }
                this.startNumber++;
            }
        }

        private void PrintVector()
        {
            Console.WriteLine(string.Join(" ", this.vector));
        }
    }
}
