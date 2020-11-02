using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeomatriOOP
{
    public class Square :Shape
    {  
        /// <summary>
        /// Constructor that takes one parameter for side A
        /// </summary>
        /// <param name="sideA"></param>
        public Square(double sideA)
        {
            this.SideA = sideA;
        }
      

    }
}