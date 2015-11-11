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
        public static double RightTriangleSquare(double firstSide, double secondSide, double thirdSide)
        {
            double square = 0;
            double max = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            if (firstSide == max)
            {
                return (secondSide * thirdSide) / 2;
            }
            if (secondSide == max)
            {
                return (firstSide * thirdSide) / 2;
            }
            if (thirdSide == max)
            {
                return (firstSide*secondSide) / 2;
            }
            return square;
        }
    }
}
