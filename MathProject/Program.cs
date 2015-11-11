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
            if (firstSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            if (secondSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            if (thirdSide <= 0) throw new ArgumentException("Side one should be greater than zero.");
            double max = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            if (2 * max > (firstSide + secondSide + thirdSide)) throw new ArgumentException("This triangle does not exists.");
            if (firstSide == max)
            {
                if (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)){
                    return (secondSide * thirdSide) / 2;
                }
            }
            if (secondSide == max)
            {
                if (Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)){
                    return (firstSide * thirdSide) / 2;
                }
            }
            if (thirdSide == max)
            {
                if (Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)){
                    return (firstSide * secondSide) / 2;
                }
            }
            throw new ArgumentException("This is not a right-angled triangle.");
        }
    }
}
