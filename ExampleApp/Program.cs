using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Figures;
using FigureAreaCalc.Figures;

namespace ExampleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Figure> figures = new List<Figure>();
			figures.Add(new Circle(3.133));
			figures.Add(new Square(4));
			figures.Add(new Triangle(2, 3, 4));
			figures.Add(new Triangle(3, 4, 6));

			figures.Add(new Triangle(10, 6, 8));
			figures.Add(new Triangle(10, 8, 6));
			figures.Add(new Triangle(6, 8, 10));
			figures.Add(new Triangle(6, 10, 8));
			figures.Add(new Triangle(8, 6, 10));
			figures.Add(new Triangle(8, 6, 10));

			figures.Add(new Rectangle(3,3));
			figures.Add(new Rectangle(3,4));

			foreach (var figure in figures)
			{
				Console.WriteLine(figure.ToString());
			}

			Console.ReadKey();
		}
	}
}
