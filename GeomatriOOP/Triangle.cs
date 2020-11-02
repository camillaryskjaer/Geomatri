using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    class Triangle : Shape
    {
        //private double _sideA;
        //private double _sideB;
        private double _SideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            this.SideC = sideC;
        }

       
        public double SideC
        {
            get { return _SideC; }
            set { _SideC = value; }
        }

        public double CalcPerimeterOfSquare()
        {
            return  SideA + SideB + SideC;
        }
        public override double CalcAreal()
        {
            return .5 * SideA * SideB;
        }
    }
}