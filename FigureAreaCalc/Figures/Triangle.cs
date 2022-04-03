using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalc.Figures
{
	public class Triangle : Figure
	{
		private double Side1 { get; set; }
		private double Side2 { get; set; }
		private double Side3 { get; set; }
		public Triangle(double side1, double side2, double side3)
		{
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
		}
		public override double GetArea()
		{
			double semiperimeter = (Side1 + Side2 + Side3) / 2;
			double area = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
			return area;
		}
		public bool IsRectangularTriangle()
		{
			return Side1 * Side1 + Side2 * Side2 == Side3 * Side3 ||
				   Side1 * Side1 + Side3 * Side3 == Side2 * Side2 ||
				   Side3 * Side3 + Side2 * Side2 == Side1 * Side1;
		}

		public override string ToString()
		{
			var str = base.ToString();
			str = IsRectangularTriangle() ? str + " and is rectangular" : str;

			return str;
		}
	}
}
