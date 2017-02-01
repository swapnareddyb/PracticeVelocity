using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeVelocity.CodingProblem.Services
{
    public class MultiplesService
    {
        public bool IsMultiple(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new Exception(@"Cannot devide with zero. Imagine that you have zero cookies, and you split them evenly among zero friends. How many cookies does each person get? See? It doesn’t make sense.");
            }
            return (numerator % denominator) == 0 ? true : false;
        }
    }
}
