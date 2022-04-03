using FigureAreaCalc.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Figures
{
	public class Rectangle : Figure
	{
		public double Side1 { get; set; }
		public double Side2 { get; set; }
		public Rectangle(double side1, double side2)
		{
			Side1 = side1;
			Side2 = side2;
		}
		public override double GetArea() => Side1 * Side2;

		public bool IsSquare() => Side1 == Side2;

		public override string ToString()
		{
			var str = base.ToString();
			str = IsSquare() ? str + " and is Square" : str;

			return str;
		}
	}
}
