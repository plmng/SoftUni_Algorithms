namespace HW_Problem2_NestedLoopsToRecursion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Generator
    {
        private readonly int minNumber = 1;

        private int[] vector;
        private readonly int maxNumber;
        
        public Generator(int n)
        {
            this.maxNumber = n;
            this.vector = new int [n];
        }

        public void GenerateCombinations()
        {
            this.Generate(0);
        }
        
        private void Generate(int index)
        {
            if (index == this.maxNumber)
	        {
		        this.PrintVector();
	        }
            else 
            {
                for (int number = 1 ; number <= this.maxNumber; number++)
			    {
			        this.vector[index] = number;
                    Generate(index+1);
			    }
            }
        }

        private void PrintVector()
        {
            Console.WriteLine(string.Join(" ", this.vector));
        }
    }
}
