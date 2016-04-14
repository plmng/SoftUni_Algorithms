namespace HW_Problem7_ConnectedAreasInMatrix
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
            char[,] firstMatrix = 
            {
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
                {' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' '},
            };

            var areaFinder = new AreaFinder(firstMatrix);
            areaFinder.PrintAllAreas();

            Console.WriteLine(new string('-', 40));

            char[,] secondMatrix = 
            {
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                { '*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            };

            areaFinder = new AreaFinder(secondMatrix);
            areaFinder.PrintAllAreas();

        }
    }
}
