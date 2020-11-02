using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    public class Parallelogram : Square
    {
        private double _angleOfCorner;

        public double AngleOfCorner
        {
            get { return _angleOfCorner; }
            set { _angleOfCorner = value; }
        }


        public Parallelogram(double sideA, double sideB, double angleOfCorner) : base(sideA)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this._angleOfCorner = angleOfCorner;
        }

        /// <summary>
        /// Returns the areal of the Parallelogram
        /// </summary>
        /// <returns></returns>
        public override double CalcAreal()
        {
            // math.pi / 180 * angleOfCorner 
            return Math.Sin((Math.PI / 180) * _angleOfCorner) * (SideA * SideB);
        }

        public override double CalcPerimeter()
        {
            return SideA * 2 + SideB * 2;
        }
    }
}