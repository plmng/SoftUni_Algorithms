namespace HW_Problem5_CombinationsWithoutRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Combinator
    {
        private int startNumber = 1;
        private int[] vector;
        private int elementstsCount;
        private int maxNumber;

        public Combinator(int n, int k)
        {
            this.maxNumber = n;
            this.elementstsCount = k;
            this.vector = new int[this.elementstsCount];
        }

        public void GenerateCombinations()
        {
            this.Generate(0, this.startNumber);
        }

        private void Generate(int index, int startNumber)
        {
            if (index == this.elementstsCount)
	        {
		        this.PrintVector();
	        }
            else 
            {
                for (int number = startNumber ; number <= this.maxNumber; number++)
			    {
			        this.vector[index] = number;
                    this.Generate(index+1, number+1);
			    }
            }
        }

        private void PrintVector()
        {
            Console.WriteLine(string.Join(" ", this.vector));
        }
    }
}
