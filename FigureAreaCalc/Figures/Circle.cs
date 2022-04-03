using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalc.Figures
{
	public class Circle : Figure
	{
		private double Radius { get; set; }
		public Circle(double radius)
		{
			Radius = radius;
		}
		public override double GetArea() => Math.PI * (Radius * Radius);
	}
}
