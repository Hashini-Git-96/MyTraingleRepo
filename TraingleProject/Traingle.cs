using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraingleProject
{
    public class Traingle
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public bool getTraingleType()
        {
            bool IsRightTriangle = false;

             if (this.SideA == this.SideB + this.SideC || this.SideB == this.SideA + this.SideC || this.SideC == this.SideA + this.SideB)
            {
                 IsRightTriangle = true;
                return IsRightTriangle;
            }
            else {
               
                return IsRightTriangle;
            }
        }
    }
}
