using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    class Trapez : Square
    {
        private double _SideC;
        private double _sideD;

        public double SideD
        {
            get { return _sideD; }
            set { _sideD = value; }
        }


        public double SideC
        {
            get { return _SideC; }
            set { _SideC = value; }
        }

        public Trapez(double sideA, double sideB, double sideC, double sideD) : base(sideA)
        {
            this.SideB = sideB;
            this._SideC = sideC;
            this._sideD = sideD;
        }

        /// <summary>
        /// is calculating Perimeter of the Trapez
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
        /// <summary>
        /// is calculating the square of a trapez
        /// </summary>
        /// <returns></returns>
        public override double CalcAreal()
        {
            double s = (SideA + SideB - SideC + SideD) / 2;
            double h = (2 / (SideA - SideC)) * Math.Sqrt(s * (s - SideA + SideC) * (s - SideB) * (s - SideD));
            return .5 * (SideA + SideC) * h;
        }
    }
}