using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    public class Shape
    {
//Du forudsætter her at alle shapes har en side eller 2...hvad med en cirkel er det ikke også en shape?
        
        
        
        // The value of side A 
        private double _sideA;
     
        
        //Du bryder med SOLID her, for du bruger aldrig B til noget som helst!
        // The value of side B If It Exists
        private double _sideB;  

        public double SideB
        {
            get { return _sideB; }
            set { _sideB = value; }
        }

        public double SideA
        {
            get { return _sideA; }
            set { _sideA = value; }
        }

        public virtual double CalcPerimeter()
        {
            return SideA * 4;
        }
        /// <summary>
        /// Calculates the areal of a square 
        /// </summary>
        /// <returns></returns>
        public virtual double CalcAreal()
        {
            return SideA * SideA;
        }
    }
}
