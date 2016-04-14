namespace HW_Problem6_PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = 
            {
                {'s', ' ', ' ', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', 'e', ' '},
                {' ', ' ', ' ', ' '},
            };

            var pathFinder = new PathsFinder(matrix);
            pathFinder.PrintAllPaths();
        }
    }
}
