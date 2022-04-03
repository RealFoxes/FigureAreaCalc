using FigureAreaCalc.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureCalcUnitTest
{
	[TestClass]
	public class TestTriangleIsRectangular
    {
        [TestMethod]
        public void TriangleIsRectangular()
        {
            var t1 = new Triangle(10, 6, 8);
            var t2 = new Triangle(10, 7, 8);
            var t3 = new Triangle(3, 3, 3);


            Assert.IsTrue(t1.IsRectangularTriangle());
            Assert.IsFalse(t2.IsRectangularTriangle());
            Assert.IsFalse(t3.IsRectangularTriangle());
        }

        [TestMethod]
        public void SidesOfTheTriangleSwitchInVariables()
        {
            var t1 = new Triangle(10, 6, 8);
            var t2 = new Triangle(10, 8, 6);
            var t3 = new Triangle(6, 8, 10);
            var t4 = new Triangle(6, 10, 8);
            var t5 = new Triangle(8, 6, 10);
            var t6 = new Triangle(8, 6, 10);

            var result = t1.IsRectangularTriangle() &&
                t2.IsRectangularTriangle() &&
                t3.IsRectangularTriangle() &&
                t4.IsRectangularTriangle() &&
                t5.IsRectangularTriangle() &&
                t6.IsRectangularTriangle();

            Assert.IsTrue(result);
        }
    }
}
