using FigureAreaCalc.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace FigureCalcUnitTest
{
	[TestClass]
	public class GetAreaTests
	{
		[TestMethod]
		public void GetAreaSquare()
		{
			var s1 = new Square(3);
			var s2 = new Square(6);
			var s3 = new Square(1);
			var s4 = new Square(2);

			Assert.AreEqual(9, s1.GetArea(), 0.05);
			Assert.AreEqual(36, s2.GetArea(), 0.05);
			Assert.AreEqual(1, s3.GetArea(), 0.05);
			Assert.AreEqual(4, s4.GetArea(), 0.05);
		}

		[TestMethod]
		public void GetAreaTriangle()
		{
			var s1 = new Triangle(2,4,5);
			var s2 = new Triangle(6,4,3);
			var s3 = new Triangle(9,5,7);
			var s4 = new Triangle(5.35, 2.36, 3.43);

			Assert.AreEqual(3.79, s1.GetArea(), 0.05);
			Assert.AreEqual(5.33, s2.GetArea(), 0.05);
			Assert.AreEqual(17.41, s3.GetArea(), 0.05);
			Assert.AreEqual(2.90, s4.GetArea(), 0.05);

		}

		[TestMethod]
		public void GetAreaCircle()
		{
			var s1 = new Circle(3);
			var s2 = new Circle(6);
			var s3 = new Circle(1);
			var s4 = new Circle(2);

			Assert.AreEqual(28.27, s1.GetArea(), 0.05);
			Assert.AreEqual(113.09, s2.GetArea(), 0.05);
			Assert.AreEqual(3.14, s3.GetArea(), 0.05);
			Assert.AreEqual(12.56, s4.GetArea(), 0.05);
		}
	}
}
