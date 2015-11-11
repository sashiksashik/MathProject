using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathProject;

namespace RightTriangleTest
{
   
    [TestClass]
    public class RightTrianleExceptionsTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "This is not a right-angled triangle.")]
        public void ExceptionNonRightTriangle()
        {
            MathMethods.RightTriangleSquare(1,1,1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Side one should be greater than zero.")]
        public void ExceptionNegtiveFirstSide()
        {
            MathMethods.RightTriangleSquare(-1, 1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Side one should be greater than zero.")]
        public void ExceptionNegtiveFirstSide2()
        {
            MathMethods.RightTriangleSquare(-1, -1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Side one should be greater than zero.")]
        public void ExceptionNegtiveFirstSide3()
        {
            MathMethods.RightTriangleSquare(-1, 1, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Side one should be greater than zero.")]
        public void ExceptionNegtiveFirstSide4()
        {
            MathMethods.RightTriangleSquare(-1, -1, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Side one should be greater than zero.")]
        public void ExceptionNegtiveSecondSide()
        {
            MathMethods.RightTriangleSquare(1, -1, 1);
        }
        [ExpectedException(typeof(ArgumentException),
         "Side one should be greater than zero.")]
        public void ExceptionNegtiveSecondSide2()
        {
            MathMethods.RightTriangleSquare(1, -1, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Side three should be greater than zero.")]
        public void ExceptionNegtiveThirdSide()
        {
            MathMethods.RightTriangleSquare(1, 1, -1);
        }

    }
}
