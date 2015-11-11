using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProject
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class MathMethods
    {
        private static double DOUBLE_COMPUTATION_ERROR = 0.0000005;
        public static double RightTriangleSquare(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            if (secondSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            if (thirdSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            double max = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            if ((Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) - 2 * Math.Pow(max, 2)) > DOUBLE_COMPUTATION_ERROR)
            {
                throw new ArgumentException("This is not a right-angled triangle.");
            }
            return (firstSide * secondSide * thirdSide) / (2 * max);
        }
    }
}
