using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.CodingProblem.Services
{
    public class MathService
    {
        public bool IsMultiple(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception(@"Cannot devide with zero.");
            }
            return (numerator % denominator) == 0 ? true : false;
        }
    }
}
