namespace HW_Problem6_PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PathsFinder
    {
        private readonly string startDirection = string.Empty;
        private int pathsFound;
        private char[,] matrix;
        private int rowCount;
        private int colCount;
        private int startRow;
        private int startCol;
        private List<string> paths;
        private List<string> currentPath;

        public PathsFinder(char [,] matrix)
        {
            this.matrix = matrix;
            this.rowCount = this.matrix.GetLength(0);
            this.colCount = this.matrix.GetLength(1);
            this.FindStartPoint();
            this.paths = new List<string>();
            this.currentPath = new List<string>();
        }

        public void PrintAllPaths() 
        {
            this.FindPath(this.startRow, this.startCol, this.startDirection);
            this.PrintPath();
        }

        private void FindPath(int row, int col, string direction) 
        {
            if (!this.IsInRange(row, col))
            {
                return;
            };
            if (this.matrix[row, col] == 'e')
            {
                this.paths.Add(string.Join("", this.currentPath));
            };
            if (this.matrix[row, col] != ' ')
            {
                return;
            };
            
            this.matrix[row, col] = '.';
            
            this.currentPath.Add(direction);    
            
            this.FindPath(row, col + 1, "R");
            this.FindPath(row + 1, col, "D");
            this.FindPath(row, col - 1, "L");
            this.FindPath(row - 1, col, "U");

            this.matrix[row, col] = ' ';
            this.currentPath.RemoveAt(this.currentPath.Count-1);

        }

        private void PrintPath() 
        {
            foreach (string path in this.paths)
            {
                Console.WriteLine(path);
            }
            Console.WriteLine("Total paths found: " + this.paths.Count);
        }

        private bool IsInRange(int row, int col) 
        {
            bool inRowRange = row >= 0 && row < this.rowCount;
            bool inColRange = col >= 0 && col < this.colCount;
            return inRowRange && inColRange;
        }

        private void FindStartPoint() 
        {
            for (int row = 0; row < this.rowCount; row++)
            {
                for (int col = 0; col < this.colCount; col++)
                {
                    if (this.matrix[row, col] == 's')
                    {
                        this.startRow = row;
                        this.startCol = col;
                        this.matrix[row, col] = ' ';
                        return;
                    }
                }
            }
        }

    }
}
