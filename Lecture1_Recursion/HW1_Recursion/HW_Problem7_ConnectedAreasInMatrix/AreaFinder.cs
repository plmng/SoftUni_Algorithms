namespace HW_Problem7_ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class AreaFinder
    {
        private OrderedBag<Area> areas;
        private Area currentArea;
        private char[,] matrix;
        private int startRow;
        private int startCol;
        private int rowCount;
        private int colCount;

        public AreaFinder(char[,] matrix)
        {
            this.matrix = matrix;
            this.areas = new OrderedBag<Area>();
            this.rowCount = this.matrix.GetLength(0);
            this.colCount = this.matrix.GetLength(1);
        }

        public void PrintAllAreas() 
        {
            this.FindAreas();
            this.PrintAreas();
        }

        private void FindAreas() 
        {
            if (!this.FindStartPoint())
            {
                return;
            }

            this.currentArea = new Area(this.startRow, this.startCol);
            this.traverseArea(this.startRow, this.startCol);
            this.areas.Add(this.currentArea);
            this.FindAreas();
        }

        private void traverseArea(int row, int col) 
        {
            if(!this.IsInRange(row, col))
            {
                return;
            };
            
            if (this.matrix[row, col] == '*')
	        {
                return;
	        }

            this.matrix[row, col] = '*';
            this.currentArea.Size++;

            this.traverseArea(row, col + 1);
            this.traverseArea(row + 1, col);
            this.traverseArea(row, col - 1);
            this.traverseArea(row - 1, col);
        }
        
        private bool IsInRange(int row, int col)
        {
            bool inRowRange = row >= 0 && row < this.rowCount;
            bool inColRange = col >= 0 && col < this.colCount;
            return inRowRange && inColRange;
        }
        private bool FindStartPoint() 
        {
            for (int row = 0; row < this.rowCount; row++)
            {
                for (int col = 0; col < this.colCount; col++)
                {
                    if (this.matrix[row, col] == ' ')
                    {
                        this.startRow = row;
                        this.startCol = col;
                        return true;
                    }
                }
            }
            return false;
        }

        private void PrintAreas() 
        {
            int index = 1;
            foreach (var area in this.areas)
            {
                Console.WriteLine(string.Format("Area #{0} at ({1}, {2}), size: {3}", index++, area.Row, area.Col, area.Size));
            }
        }
    }
}
