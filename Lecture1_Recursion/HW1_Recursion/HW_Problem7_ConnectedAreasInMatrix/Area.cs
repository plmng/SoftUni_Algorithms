namespace HW_Problem7_ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Area : IComparable<Area>
    {
        public Area(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.Size = 0;
        }
        public int Row { get; set; }
        public int Col { get; set; }
        public int Size { get; set; }

        public int CompareTo(Area other) 
        {
            if (this.Size == other.Size)
            {
                if (this.Row==other.Row)
                {
                    return this.Col - other.Col;   
                }
                return this.Row - other.Row;
            }
            return other.Size - this.Size;
        }
    }
}
