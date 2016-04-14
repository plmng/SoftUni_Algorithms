namespace HW_Problem4_TowerOfHanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HanoiTower
    {
        private readonly int initialCount = 1;
        private int stepsTaken = 0;
        private int elementsCount;
        private Stack<int> sourse;
        private Stack<int> spare;
        private Stack<int> destination;
        
        public HanoiTower(int elementsCount)
        {
            this.elementsCount = elementsCount;
            this.sourse = new Stack<int>(Enumerable.Range(initialCount, this.elementsCount).Reverse());
            this.spare = new Stack<int>();
            this.destination = new Stack<int>();
        }

        public void MoveElements()
        {
            this.PrintRods();
            this.Move(this.elementsCount, this.sourse, this.destination, this.spare);
           
        }

        private void Move(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod) 
        {
            if (bottomDisk == 1)
            {
                destinationRod.Push(sourceRod.Pop());
                Console.WriteLine("Step #{0}: Moved disk {1}.", ++this.stepsTaken, bottomDisk);
                this.PrintRods();
            }
            else
            {
                Move(bottomDisk - 1, sourceRod, spareRod, destinationRod);

                destinationRod.Push(sourceRod.Pop());
                Console.WriteLine("Step #{0}: Moved disk {1}.", ++this.stepsTaken, bottomDisk);
                this.PrintRods();

                Move(bottomDisk - 1, spareRod, destinationRod, sourceRod);
            }
        }

        private void PrintRods() 
        {
            Console.WriteLine("Source: {0}", string.Join(", ", this.sourse.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", this.destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", this.spare.Reverse()));
            Console.WriteLine();
        }
    }
}
