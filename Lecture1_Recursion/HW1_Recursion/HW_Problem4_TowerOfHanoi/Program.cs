namespace HW_Problem4_TowerOfHanoi
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
            Console.Write("n=");
            int numberOfDisks = int.Parse(Console.ReadLine());
            var tower = new HanoiTower(numberOfDisks);
            tower.MoveElements();
        }
    }
}
