using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalc.Figures
{
    abstract public class Figure
    {
        protected Figure() { }
        public virtual double GetArea() => throw new NotImplementedException();

		public override string ToString()
		{
			return $"Figure {this.GetType().Name} has area: {this.GetArea()}";
		}
	}
}
