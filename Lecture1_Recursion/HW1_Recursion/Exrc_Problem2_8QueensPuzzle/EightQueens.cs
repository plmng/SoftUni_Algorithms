using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_Problem2_8QueensPuzzle
{
    public class EightQueens
    {
        const int Size = 8;
        private int solutionsFound = 0;
        private bool[,] chessboard = new bool[Size, Size];
        private HashSet<int> attackedRows = new HashSet<int>();
        private HashSet<int> attackedColumns = new HashSet<int>();
        // Left Diagonal = col - row
        private HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        // Right Diagonal = col + row
        private HashSet<int> attackedRightDiagonal = new HashSet<int>();

        public void PutQueens()
        {
            this.PutQueen(0);
        }

        private void PutQueen(int row) 
        {
            if (row == Size)
            {
                this.PrintSolution();
            }
            else 
            {
                for (int col = 0; col < Size; col++)
                {
                    if (this.CanPlaseQueen(row, col))
                    {
                        this.MarkAllAttackedPosition(row, col);
                        this.PutQueen(row + 1);
                        this.UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private bool CanPlaseQueen(int row, int col) 
        {
            if (this.attackedRows.Contains(row) ||
                this.attackedColumns.Contains(col) ||
                this.attackedLeftDiagonal.Contains(col - row) ||
                this.attackedRightDiagonal.Contains(col + row)) 
            {
                return false;
            }
            return true;
        }

        private void MarkAllAttackedPosition(int row, int col)
        {
            var leftDiagonal = col - row;
            var rightDiagonal = col + row;
            
            this.attackedColumns.Add(col);
            this.attackedRows.Add(row);
            this.attackedLeftDiagonal.Add(leftDiagonal);
            this.attackedRightDiagonal.Add(rightDiagonal);
            this.chessboard[row, col] = true;
        }

        private void UnmarkAllAttackedPositions(int row, int col)
        {
            var leftDiagonal = col - row;
            var rightDiagonal = col + row;
            
            this.attackedColumns.Remove(col);
            this.attackedRows.Remove(row);
            this.attackedLeftDiagonal.Remove(leftDiagonal);
            this.attackedRightDiagonal.Remove(rightDiagonal);
            this.chessboard[row, col] = false;
        }

        private void PrintSolution() 
        {
            this.solutionsFound ++;
            Console.WriteLine("Found Solution: " + this.solutionsFound);
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (this.chessboard[row, col])
                    {
                        Console.Write('*');
                    }
                    else
	                {
                        Console.Write('-');
	                }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
