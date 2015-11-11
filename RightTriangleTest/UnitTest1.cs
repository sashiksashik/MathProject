using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathProject;

namespace RightTriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CorrectSymmetryComputationIntegerValues()
        {
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(3, 4, 5));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(3, 5, 4));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(4, 3, 5));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(4, 5, 3));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(5, 4, 3));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(5, 3, 4));
        }
        [TestMethod]
        public void CorrectSymmetryComputationFloatValues()
        {
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(1, 1, Math.Sqrt(2)));
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(1, Math.Sqrt(2), 1));
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(1, 1, Math.Sqrt(2)));
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(1, Math.Sqrt(2), 1));
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(Math.Sqrt(2), 1, 1));
            Assert.AreEqual(0.5, MathMethods.RightTriangleSquare(Math.Sqrt(2), 1, 1));
        }
        [TestMethod]
        public void PythagoreanTriple()
        {
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(5, 12, 13));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(8, 15, 17));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(7, 24, 25));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(20, 21, 29));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(12, 35, 37));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(161, 240, 289));
            Assert.AreEqual(6, MathMethods.RightTriangleSquare(95, 168, 193));
        }

    }
}
