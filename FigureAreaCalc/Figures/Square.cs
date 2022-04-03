using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalc.Figures
{
	public class Square : Figure
	{
		private double Side { get; set; }

		public Square(double side)
		{
			Side = side;
		}

		public override double GetArea() => Side * Side;

	}
}
